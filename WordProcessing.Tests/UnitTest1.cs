using NUnit.Framework;
using System.Linq;

namespace WordParsing.Tests
{
    public class WordParsingTests
    {
        [Test]
        public void Finds_Words_Separated_By_Punctuation_And_Whitespace()
        {
            string text = "hello.hello?hello!hello;hello:hello hello\thello\r\nhello\"hello\"";

            var wordParser = CreateWordParser();
            var results = wordParser.Parse(text);

            CollectionAssert.AreEqual(Enumerable.Repeat<string>("hello", 10), results);
        }

        private WordParser CreateWordParser()
        {
            return new WordParser();
        }
    }
}