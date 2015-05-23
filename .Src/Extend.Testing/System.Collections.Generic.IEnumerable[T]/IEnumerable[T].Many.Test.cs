﻿#region Usings

using System;
using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class IEnumerableTExTest
    {
        [Test]
        public void ManyTestCase()
        {
            var list = new List<String>();
            Assert.IsFalse( list.Many() );

            list = RandomValueEx.GetRandomStrings( 1 );
            Assert.IsFalse( list.Many() );

            list = RandomValueEx.GetRandomStrings( 10 );
            Assert.IsTrue( list.Many() );
        }

        [Test]
        public void ManyTestCase1()
        {
            var list = new List<String>();
            Assert.IsFalse( list.Many( x => true ) );

            list = RandomValueEx.GetRandomStrings( 1 );
            Assert.IsFalse( list.Many( x => true ) );

            list = RandomValueEx.GetRandomStrings( 10 );
            Assert.IsFalse( list.Many( x => false ) );
            Assert.IsTrue( list.Many( x => true ) );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ManyTestCase1NullCheck()
        {
            List<Object> list = null;
            list.Many( x => true );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ManyTestCase1NullCheck1()
        {
            new List<Object>().Many( null );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ManyTestCaseNullCheck()
        {
            List<Object> list = null;
            list.Many();
        }
    }
}