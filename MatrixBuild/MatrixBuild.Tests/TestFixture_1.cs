using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MatrixBuild.Tests
{
    [TestFixture]
   internal sealed class TestFixture_1
    {
        [Category("A")]
        public bool IsTrueTest()
        {
            return true;
        }

        [Category("B")]
        [TestCase(Result = 0)]
        public int GetIntTest()
        {
            return 0;
        }
    }
}
