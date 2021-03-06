﻿#region Usings

using System;
using System.Globalization;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Creates a new <see cref="CultureInfo" /> with the given name.
        /// </summary>
        /// <exception cref="ArgumentNullException">name can not be null.</exception>
        /// <exception cref="CultureNotFoundException">Culture is not supported.</exception>
        /// <param name="name">The name of the culture.</param>
        /// <returns>Returns the <see cref="CultureInfo" /> with the given name.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static CultureInfo ToCultureInfo( [NotNull] this String name )
        {
            name.ThrowIfNull( nameof(name) );

            return new CultureInfo( name );
        }
    }
}