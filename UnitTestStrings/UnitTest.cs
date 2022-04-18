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

            string text2 = "Нынешний же пламенный юноша отскочил бы с ужасом, если бы показали ему его же портрет в старости. Забирайте же с собою в путь, выходя из мягких юношеских лет в суровое ожесточающее мужество, забирайте с собою все человеческие движения, не оставляйте их на дороге, не подымете потом! Грозна, страшна грядущая впереди старость, и ничего не отдает назад и обратно!";
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "Нынешний", 0), 0);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "Забирайте", 0), 98);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "с ужасом", 25), 40);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "забирайте", 99), 191);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "обратно", 0), 353);
        }

        [TestMethod]
        public void IndexOf_KMP_ReturnsIndex() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.AreEqual(Strings.IndexOf_KMP(text, "можно быть", 0), 4);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "Как", 0), 0);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "в наше время", 0), 87);
            Assert.AreEqual(Strings.IndexOf_KMP(text, "когда", 0), 25);

            string text2 = "Лениво дышит полдень мглистый, Лениво катится река - И в тверди пламенной и чистой. Лениво тают облака";
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "Лениво", 0), 0);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "полдень", 0), 13);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "река", 25), 46);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "Лениво", 70), 84);
            Assert.AreEqual(Strings.IndexOfAny_Primitive(text2, "чистой", 0), 76);
        }

        [TestMethod]
        public void IndexOfKMP_Best_ReturnsList() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "когда", 0)[0], 25);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "когда", 0)[1], 101);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "можно", 0)[0], 4);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text, "можно", 0)[1], 60);

            string text2 = "Лениво дышит полдень мглистый, Лениво катится река - И в тверди пламенной и чистой. Лениво тают облака";
            Assert.AreEqual(Strings.IndexOfKMP_Best(text2, "Лениво", 0)[0], 0);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text2, "Лениво", 0)[1], 31);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text2, "Лениво", 80)[0], 84);
            Assert.AreEqual(Strings.IndexOfKMP_Best(text2, "дышит", 0)[0], 7);
        }

        [TestMethod]
        public void IsPattern_ReturnsBool() {
            string text = "Как можно быть здоровой… когда нравственно страдаешь? Разве можно оставаться спокойною в наше время, когда есть у человека чувство?";

            Assert.IsTrue(Strings.IsPattern(text, "можно быть", 4));
            Assert.IsTrue(Strings.IsPattern(text, "Как", 0));
            Assert.IsTrue(Strings.IsPattern(text, "в наше время", 87));
            Assert.IsTrue(Strings.IsPattern(text, "когда", 25));

            string text2 = "Лениво дышит полдень мглистый, Лениво катится река - И в тверди пламенной и чистой. Лениво тают облака";
            Assert.IsTrue(Strings.IsPattern(text2, "Лениво", 0));
            Assert.IsTrue(Strings.IsPattern(text2, "полдень", 13));
            Assert.IsTrue(Strings.IsPattern(text2, "река", 46));
            Assert.IsTrue(Strings.IsPattern(text2, "Лениво", 84));
            Assert.IsTrue(Strings.IsPattern(text2, "чистой", 76));
        }

        [TestMethod]
        public void PrefixFunction_ReturnsArr() {
            Assert.AreEqual(Strings.PrefixFunction("abab")[3], 2);
            Assert.AreEqual(Strings.PrefixFunction("abab")[2], 1);
            Assert.AreEqual(Strings.PrefixFunction("abab")[1], 0);
            Assert.AreEqual(Strings.PrefixFunction("ababuiabc")[3], 2);
            Assert.AreEqual(Strings.PrefixFunction("ababuiabc")[7], 2);

            Assert.AreEqual(Strings.PrefixFunction("абракадабра")[3], 1);
            Assert.AreEqual(Strings.PrefixFunction("абракадабра")[4], 0);
            Assert.AreEqual(Strings.PrefixFunction("абракадабра")[5], 1);
            Assert.AreEqual(Strings.PrefixFunction("абракадабра")[8], 2);
            Assert.AreEqual(Strings.PrefixFunction("абракадабра")[10], 4);
        }
    }
}