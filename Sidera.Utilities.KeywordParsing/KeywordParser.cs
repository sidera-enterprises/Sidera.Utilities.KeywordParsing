using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Web;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///     Represents a utility containing a lookup dictionary used for
    ///     replacing instances of square bracket-delimited keywords within
    ///     a specified expression string with defined values.
    /// </summary>
    public class KeywordParser
    {
        #region Initialization
        private const string _RESERVED_CHARS = "[](){}:";

        private SortedDictionary<string, object> _dictionary;

        public KeywordParser()
        {
            _dictionary = new SortedDictionary<string, object>();

            Timer timer = new Timer(1);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            // Dates
            SetKeyword("@CurrentDate", DateTime.Now, true);

            // Machine info
            SetKeyword("@MachineName", Dns.GetHostName(), true);

            // User info
            WindowsIdentity userid = WindowsIdentity.GetCurrent();
            string principal, domain, username, displayname;
            principal = userid.Name;
            domain = principal.Split(new char[] { '\\' })[0];
            username = principal.Split(new char[] { '\\' })[1];
            displayname = UserPrincipal.Current.DisplayName;
            SetKeyword("@PrincipalUserDomain", domain, true);
            SetKeyword("@PrincipalUserName", username, true);

            // App info
            Assembly assembly, executable;
            assembly = Assembly.GetExecutingAssembly();
            executable = Assembly.GetEntryAssembly();
            FileInfo fiAssembly, fiExecutable;
            fiAssembly = new FileInfo(assembly.Location);
            fiExecutable = new FileInfo(executable.Location);
            SetKeyword("@ExecutableDirectory",
                fiExecutable.Directory.FullName, true);
            SetKeyword("@ExecutableFileName",
                fiExecutable.Name, true);
            SetKeyword("@ExecutableName", executable != null ? executable.GetName().Name : "", true);
        }

        #region Public properties
        /// <summary>
        ///     Gets a collection containing the dictionary keys for the
        ///     <see cref="KeywordParser"/>.
        /// </summary>
        public string[] Keys
        {
            get
            {
                return _dictionary.Keys.ToArray();
            }
        }

        /// <summary>
        ///     Gets a collection containing the dictionary values for the
        ///     <see cref="KeywordParser"/>.
        /// </summary>
        public object[] Values
        {
            get
            {
                return _dictionary.Values.ToArray();
            }
        }
        #endregion

        #region Internal properties
        internal SortedDictionary<string, object> Keywords
        {
            get
            {
                return _dictionary;
            }
        }

        internal SortedDictionary<string, Type> KeywordTypes
        {
            get
            {
                SortedDictionary<string, Type> types = new SortedDictionary<string, Type>();

                foreach (KeyValuePair<string, object> kvp in _dictionary)
                {
                    string key = kvp.Key;
                    Type type = (kvp.Value ?? new object()).GetType();

                    types.Add(key, type);
                }

                return types;
            }
        }
        #endregion

        #region Public methods
        /// <inheritdoc cref="KeywordParser.Parse(string, KeywordParseOptions)"/>
        public string Parse(string expression)
        {
            return Parse(expression, KeywordParseOptions.None);
        }

        /// <summary>
        ///     Replaces all instances of keywords as defined in the lookup dictionary with their defined values. The
        ///     default keyword parse option is set to <see cref="KeywordParseOptions.None"/>.
        /// </summary>
        /// <param name="expression">
        ///     The expression string to search for keywords.
        /// </param>
        /// <param name="options">
        ///     A value indicating how undefined keywords should be handled during parsing.
        /// </param>
        /// <returns>
        ///     A new string wherein all defined keywords have been replaced with their defined values.
        /// </returns>
        /// <exception cref="UndefinedKeywordException"></exception>
        public string Parse(string expression, KeywordParseOptions options)
        {
            char[] reservedChars = _RESERVED_CHARS.ToCharArray();

            // Search expression for [keywords] in suqare brackets; replace single brackets with double brackets
            string[] keys, keywords;
            keys = _dictionary.Keys.ToArray();
            keywords = keys.Select(k => $"[{k}]").ToArray();

            string result = expression;

            // Match all instances of [keywords] in square brackets
            string kwpattern = @"\[([^]]*)\]";
            MatchCollection placeholders = Regex.Matches(expression, kwpattern);

            // Iterate through instances of the current keyword
            foreach (Match placeholder in placeholders)
            {
                Match mKey, mFormat, mRange, mCasing;
                bool hasFormat, hasRange, hasCasing;
                string name, key, format, range, casing, value;

                name = placeholder.Value;

                mKey = Regex.Match(name, @"\[(.*?)[\(|\{|\]\:]");
                mFormat = Regex.Match(name, @"\((.*)\)");
                mRange = Regex.Match(name, @"\{(.*)\}");
                mCasing = Regex.Match(name, @"\:(.*?)[\(|\{|\]]");

                hasFormat = name.Contains("(") && name.Contains(")");
                hasRange = name.Contains("{") && name.Contains("}");
                hasCasing = name.Contains(":");

                key = mKey.Groups.Count > 1 ? mKey.Groups[1].Value : "";
                format = mFormat.Groups.Count > 1 ? mFormat.Groups[1].Value : "";
                range = mRange.Groups.Count > 1 ? mRange.Groups[1].Value : "";
                casing = mCasing.Groups.Count > 1 ? mCasing.Groups[1].Value : "";

                if (_dictionary.ContainsKey(key))
                {
                    // Initialize value
                    value = "";

                    try
                    {
                        // Set string format
                        value = string.Format($"{{0:{format}}}", _dictionary[key]);

                        // Set substring values
                        string[] substringParts = range.Split(new char[] { ',' }).ToArray();
                        if (substringParts.Length > 0)
                        {
                            int substart, sublength;
                            substart = 0;
                            sublength = value.Length;

                            if (int.TryParse(substringParts[0], out substart))
                            {
                                substart = int.Parse(substringParts[0]);

                                if (substringParts.Length > 1 && int.TryParse(substringParts[1], out sublength))
                                {
                                    sublength = Math.Max(0,
                                        Math.Min(value.Length - substart, int.Parse(substringParts[1])));

                                    // If start value is negative, set value relative to end of string
                                    if (substart < 0)
                                    {
                                        int offset = Math.Max(0,
                                            Math.Min(value.Length, value.Length - Math.Abs(substart)));

                                        substart = offset;
                                        sublength = Math.Max(0,
                                            Math.Min(value.Length - substart, sublength));
                                    }
                                }
                            }

                            value = value.Substring(substart, sublength);
                        }

                        // Set character casing
                        bool upper, lower;
                        upper = (casing == "ABC"
                            || casing.ToUpper() == "U"
                            || casing.ToUpper() == "UPPER"
                            || casing.ToUpper() == "UPPERCASE");
                        lower = (casing == "abc"
                            || casing.ToUpper() == "L"
                            || casing.ToUpper() == "LOWER"
                            || casing.ToUpper() == "LOWERCASE");

                        if (upper)
                        {
                            value = value.ToUpper();
                        }
                        else if (lower)
                        {
                            value = value.ToLower();
                        }
                    }
                    catch
                    {
                        // Do not handle the exception.
                        // A malformed string should not necessarily cause the application to throw an exception.

                        // Set string format
                        value = string.Format("{0}", _dictionary[key]);
                    }
                    finally
                    {
                        // Capture indices and lengths of captured placeholders
                        int index, length;
                        index = result.IndexOf(name);
                        length = name.Length;

                        // Replace placeholder text with associated value
                        result = result
                            .Remove(index, length)
                            .Insert(index, value);
                    }
                }
                else
                {
                    switch (options)
                    {
                        case KeywordParseOptions.RemovePlaceholders:
                            result = result.Replace(placeholder.Value, "");
                            break;
                        case KeywordParseOptions.ThrowError:
                            throw new UndefinedKeywordException($"No definition found for the keyword '{key}'.");
                    }
                }
            }

            return result;
        }

        /// <inheritdoc cref="KeywordParser.SetKeyword{T}(string, T, bool)"/>
        public void SetKeyword<T>(string key, T value)
        {
            SetKeyword(key, value, false);
        }

        /// <summary>
        ///     Removes the dictionary entry containing the specified keyword from the lookup dictionary.
        /// </summary>
        /// <param name="key">
        ///     The name of the keyword to search. This argument must not contain the characters '[' or ']';
        ///     otherwise, a <see cref="FormatException"/> will be thrown.
        /// </param>
        /// <exception cref="FormatException"></exception>
        public void RemoveKeyword(string key)
        {
            char[] reservedChars = _RESERVED_CHARS.ToCharArray();

            // Check the keyword name for any reserved characters
            bool invalidName = false;
            foreach (char c in reservedChars)
            {
                if (key.Contains(c))
                {
                    invalidName = true;
                    break;
                }
            }

            // Evaluate only if name is valid
            if (!invalidName)
            {
                string keyTrimmed = key.Trim();

                if (!keyTrimmed.StartsWith("@"))
                {
                    _dictionary.Remove(key);
                }
                else
                {
                    throw new FormatException($"Keywords beginning with the '@' character are reserved and cannot "
                        + "be removed.");
                }
            }
            else
            {
                throw new FormatException($"Key cannot contain reserved characters "
                    + $"('{string.Join("', '", reservedChars)}').");
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        ///     Assigns a value to the specified key in the lookup dictionary. If the key is new, it will be added to
        ///     the dictionary; otherwise, the existing key will be overwritten with the specified value.
        /// </summary>
        /// <typeparam name="T">
        ///     The data type of the object being assigned to the keyword.
        /// </typeparam>
        /// <param name="key">
        ///     The name of the keyword to search. This argument must not contain the characters '[' or ']';
        ///     otherwise; a <see cref="FormatException"/> will be thrown.
        /// </param>
        /// <param name="value">
        ///     The value with which to replace all instances of the specified keyword in the expression string.
        /// </param>
        /// <param name="fromInternal">
        ///     A value indicating whether the key is set from within this class. If true, the character '@' may be
        ///     placed at the beginning of the key to indicate that the keyword is reserved. The publicly visible
        ///     overload for this method sets this parameter to false.
        /// </param>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="IllegalTypeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        private void SetKeyword<T>(string key, T value, bool fromInternal)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                // Check if the object type T is valid
                if (LegalTypes.IsLegalType(typeof(T)))
                {
                    char[] reservedChars = _RESERVED_CHARS.ToCharArray();

                    // Check the keyword name for any reserved characters
                    bool invalidName = false;
                    foreach(char c in reservedChars)
                    {
                        if (key.Contains(c))
                        {
                            invalidName = true;
                            break;
                        }
                    }

                    // Evaluate only if name is valid
                    if (!invalidName)
                    {
                        string keyTrimmed = key.Trim();

                        if (keyTrimmed.StartsWith("@") == fromInternal)
                        {
                            // Check if key exists. If false, add a new key/value pair; otherwise, overwrite the
                            // existing value.
                            if (!_dictionary.ContainsKey(keyTrimmed))
                            {
                                _dictionary.Add(keyTrimmed, value);
                            }
                            else
                            {
                                _dictionary[keyTrimmed] = value;
                            }
                        }
                        else
                        {
                            throw new FormatException($"Keywords beginning with the '@' character are reserved and "
                                + $"cannot be externally modified.");
                        }
                    }
                    else
                    {
                        throw new FormatException($"Key cannot contain reserved characters "
                            + $"('{string.Join("', '", reservedChars)}').");
                    }
                }
                else
                {
                    throw new IllegalTypeException($"The object type '{typeof(T).FullName}' cannot be used in this "
                        + $"instance.");
                }
            }
            else
            {
                throw new ArgumentNullException($"Key cannot be null or consist entirely of white-space characters.");
            }
        }
        #endregion

        #region Private events
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SetKeyword("@CurrentDate", DateTime.Now, true);
        }
        #endregion
        #endregion
    }
}
