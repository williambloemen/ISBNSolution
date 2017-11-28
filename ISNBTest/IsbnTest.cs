using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISBN;

namespace ISNBTest
{
    [TestClass]
    public class IsbnTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetNummer0IsVerkeerd()
        {
            new Isbn(0);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsVerkeerd()
        {
            new Isbn(-9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet12CijfersIsVerkeerd()
        {
            new Isbn(978902743964L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet14CijfersIsVerkeerd()
        {
            new Isbn(97890274396421L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal2()
        {
            new Isbn(8789027439642L);
        }
        [TestMethod]
        public void EenNummerMet13CijfersMetCorrectControleGetal2()
        {
            new Isbn(9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal0()
        {
            new Isbn(7789227439640L);
        }
        [TestMethod]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {
            new Isbn(9789227439640L);
        }

    }
}
