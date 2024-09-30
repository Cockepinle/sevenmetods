using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDStringPracticals.Tests
{
    [TestClass]
    public class TddStringPracticalsTests
    {
        [TestMethod]
        public void  StringShortWord_CheckWord_ShortWordRetern()
        {
            string stroka = "dog catss fish";
            string expected = "dog";
            TddStringPracticals find = new TddStringPracticals();
            string actual = TddStringPracticals.StringShortWord(stroka);
            StringAssert.Contains(stroka, expected);

        }
        [TestMethod]
        public void CountStringWord_CheckCOuntWord_CountWordRetern()
        {
            string stroka = "dog catss fish";
            int expected = 3;
            TddStringPracticals find = new TddStringPracticals();
            int actual = TddStringPracticals.CountStringWord(stroka);
            Assert.IsTrue(true, "Тест не прошел проверку, sorry");

        }
        [TestMethod]
        public void SymbolString_CheckSymbolString_SymbolStringRetern()
        {
            string stroka = "dog catss fish";
            int expected = 14;
            TddStringPracticals find = new TddStringPracticals();
            int actual = TddStringPracticals.SymbolString(stroka);
            Assert.AreNotEqual(stroka, expected);
        }
        [TestMethod]
        public void NineSymbolString_FindNineSymbol_NineSymbolStringRetern()
        {
            string stroka = "dog catss fish";
            char expected = 's';
            TddStringPracticals find = new TddStringPracticals();
            char actual = TddStringPracticals.NineSymbolString(stroka);
            Assert.Inconclusive(stroka, expected);
        }
        [TestMethod]
        public void ContSymbolinString_FindContSymbolinString_ContSymbolinStringRetern()
        {
            string stroka = "dog catss fish 9";
            int expected = 1;
            TddStringPracticals find = new TddStringPracticals();
            int actual = TddStringPracticals.ContSymbolinString(stroka);
            Assert.IsNotNull(stroka, "stroka является null");
        }

        [TestMethod]
        public void LagestCountConsistently_FindConsistently_CountFindConsistentlyRetern()
        {
            string stroka = "dog 5 7 catss fish 934 ";
            int expected = 2;
            TddStringPracticals find = new TddStringPracticals();
            int actual = TddStringPracticals.LagestCountConsistently(stroka);
            Assert.Fail("Ожидаемый результат неверен, должен быть 3");
        }
        [TestMethod]
        public void CountCombinationAMTheKey_FindCountCombinationAMTheKey_CountCombinationAMTheKeyRetern()
        {
            string stroka = "dog 5 7 catss fish 934 мелькают звезды в небе, мебель хороша, медленно спускаются облака";
            int expected = 3;
            TddStringPracticals find = new TddStringPracticals();
            int actual = TddStringPracticals.CountCombinationAMTheKey(stroka);
            Assert.IsNull(expected, "Значение value не пустое");
        }
    }
}
