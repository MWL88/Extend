﻿#region Usings

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void ToInt16TestCase()
        {
            var value = RandomValueEx.GetRandomInt16();
            var actual = value.ToString()
                              .ToInt16();

            Assert.AreEqual( value, actual );
        }

        [Test]
        public void ToInt16TestCase1()
        {
            var value = RandomValueEx.GetRandomInt16();
            var actual = value.ToString( CultureInfo.InvariantCulture )
                              .ToInt16( CultureInfo.InvariantCulture );

            Assert.AreEqual( value, actual );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt16TestCase1NullCheck()
        {
            StringEx.ToInt16( null, CultureInfo.InvariantCulture );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt16TestCase1NullCheck1()
        {
            "".ToInt16( null );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt16TestCaseNullCheck()
        {
            StringEx.ToInt16( null );
        }
    }
}