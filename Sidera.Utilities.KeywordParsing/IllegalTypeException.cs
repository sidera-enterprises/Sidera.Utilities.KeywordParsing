using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///   The exception that is thrown due to a type that is used in the
    ///   <see cref="KeywordParser"/> and is determined to be an invalid type.
    /// </summary>
    public class IllegalTypeException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="IllegalTypeException"/> class.
        /// </summary>
        internal IllegalTypeException() : base() { }

        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="IllegalTypeException"/> class with a specified
        ///     error message.
        /// </summary>
        /// <param name="message"></param>
        internal IllegalTypeException(string message) : base(message) { }
    }
}
