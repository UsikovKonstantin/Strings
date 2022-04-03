using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryStrings;

namespace UnitTestStrings
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IndexOfAny_Primitive_ReturnsIndex()
        {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.AreEqual(Strings.IndexOfAny_Primitive(text, "можно быть", 0), 4);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text, "Как", 0), 0);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text, "в наше время", 0), 87);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text, "когда", 0), 25);
        }

        [TestMethod]
        public void IndexOf_KMP_ReturnsIndex() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.AreEqual(Strings.IndexOf_KMP(text, "можно быть", 0), 4);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "Как", 0), 0);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "в наше время", 0), 87);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "когда", 0), 25);
        }

        [TestMethod]
        public void IndexOfKMP_Best_ReturnsList() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "когда", 0)[0], 25);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "когда", 0)[1], 101);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "можно", 0)[0], 4);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "можно", 0)[1], 60);

        }

        [TestMethod]
        public void IsPattern_ReturnsBool() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.IsTrue(Strings.IsPattern(text, "можно быть", 4));
            Assert.IsTrue(Strings.IsPattern(text, "Как", 0));
            Assert.IsTrue(Strings.IsPattern(text, "в наше время", 87));
            Assert.IsTrue(Strings.IsPattern(text, "когда", 25));
        }

        [TestMethod]
        public void PrefixFunction_ReturnsArr() {
            Assert.AreEqual(Strings.PrefixFunction("abab")[3], 2);
            Assert.AreEqual(Strings.PrefixFunction("abab")[2], 1);
            Assert.AreEqual(Strings.PrefixFunction("abab")[1], 0);
            Assert.AreEqual(Strings.PrefixFunction("ababuiabc")[3], 2);
            Assert.AreEqual(Strings.PrefixFunction("ababuiabc")[7], 2);
        }
    }
}