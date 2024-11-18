using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///     Specifies how the keyword parser should handle keys that are not
    ///     defined in the lookup dictionary.
    /// </summary>
    public enum KeywordParseOptions
    {
        /// <summary>
        ///     Indicates that all instances of undefined keys should be left
        ///     as-is, without being parsed or removed from the result string.
        /// </summary>
        None,

        /// <summary>
        ///     Indicates that all instances of undefined keys shuold be
        ///     removed from the result string.
        /// </summary>
        RemovePlaceholders,

        /// <summary>
        ///     Indicates that an exception should be thrown indicating that
        ///     the uninitiated key could not be found in the lookup
        ///     dictionary.
        /// </summary>
        ThrowError
    }
}
