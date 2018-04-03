using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCollezione;

namespace LibraryCollezione.Test
{
    [TestClass]
    public class VettoreTest
    {
        [TestMethod]
        public void TestArrayOrdinamento()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] { 4, 11, 3, 22 };
            int[] vettoreOrdinato = Vettore.Ordinamento(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);
        }
    }
}
