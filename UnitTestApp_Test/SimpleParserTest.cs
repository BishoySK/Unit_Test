using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestApp;

namespace UnitTestApp_Test
{
    [TestFixture]
    public class SimpleParserTest
    {
        [Test]
        public void ParseAndSum_OneNumber_Test()
        {
            SampleParser sampleParser = new SampleParser();

           var result= sampleParser.ParseAndSum("5");

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void ParseAndSum_Zero_Test()
        {
            SampleParser sampleParser = new SampleParser();

            var result = sampleParser.ParseAndSum("0");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ParseAndSum_MoreThanOneNumber_Test()
        {
            SampleParser sampleParser = new SampleParser();

            Assert.That(()=>sampleParser.ParseAndSum("5,8"), Throws.TypeOf<InvalidOperationException>());
        }


        [Test]
        public void NoRepeat_Test()
        {
            SampleParser sampleParser = new SampleParser();

            var result = sampleParser.NoRepeat("Hello", 'z');

            Assert.That(result, Is.EqualTo("Hello"));
        }


        [Test]
        public void NoRepeat_RepeatOneChar_Test()
        {
            SampleParser sampleParser = new SampleParser();

            var result = sampleParser.NoRepeat("Hello", 'e');

            Assert.That(result, Is.EqualTo("Hllo"));
        }

        [Test]
        public void NoRepeat_RepeatTwoChar_Test()
        {
            SampleParser sampleParser = new SampleParser();

            var result = sampleParser.NoRepeat("Hello", 'l');

            Assert.That(result, Is.EqualTo("Heo"));
        }
    }
}
