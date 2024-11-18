using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///   The exception that is thrown when a keyword parser object fails to
    ///   find a definition for a keyword during expression parsing. This
    ///   exception is only thrown when
    ///   <see cref="KeywordParser.Parse(string, KeywordParseOptions)"/> is
    ///   executed for
    ///   <see cref="KeywordParseOptions.ThrowError"/>.
    /// </summary>
    public class UndefinedKeywordException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="UndefinedKeywordException"/> class.
        /// </summary>
        internal UndefinedKeywordException() : base() { }

        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="UndefinedKeywordException"/> class with a specified
        ///     error message.
        /// </summary>
        /// <param name="message"></param>
        internal UndefinedKeywordException(string message) : base(message) { }
    }
}
