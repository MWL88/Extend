﻿#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Extracts all Doubles from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the doubles from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted doubles.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Double> ExtractAllDouble( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Double>( ExtractAllFloatingNumbers( value, startIndex )
                                     .Select( x => x.ToDouble() ) );
    }
}