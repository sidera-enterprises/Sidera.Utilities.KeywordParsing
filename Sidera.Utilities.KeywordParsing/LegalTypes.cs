using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidera.Utilities.KeywordParsing
{
    /// <summary>
    ///     Provides the list of data types allowed for defined values used
    ///     in the <see cref="KeywordParser"/> and functionality to check
    ///     whether a data type is legal in that context.
    /// </summary>
    public static class LegalTypes
    {
        /// <summary>
        ///     Gets the list of allowed data types.
        /// </summary>
        public static Type[] Types
        {
            get
            {
                return new Type[]
                {
                    typeof(System.Boolean),
                    typeof(System.Byte),
                    typeof(System.Byte[]),
                    typeof(System.Char),
                    typeof(System.DateTime),
                    typeof(System.Decimal),
                    typeof(System.Double),
                    typeof(System.Int16),
                    typeof(System.Int32),
                    typeof(System.Int64),
                    typeof(System.Object),
                    typeof(System.Single),
                    typeof(System.String),
                    typeof(System.TimeSpan),
                    typeof(System.UInt16),
                    typeof(System.UInt32),
                    typeof(System.UInt64),
                };
            }
        }

        /// <summary>
        ///     Checks whether the provided <paramref name="type"/> is
        ///     included in the allowed types list.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsLegalType(Type type)
        {
            return Types.Contains(type);
        }
    }
}
