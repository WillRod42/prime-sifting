using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void GetPrimes_ReturnEmptyArray_IntArray()
    {
      CollectionAssert.AreEqual(new List<int> {}, Prime.GetPrimes(0));
    }

    [TestMethod]
    public void GetPrimes_ReturnArrayWithTwo_IntArray()
    {
      CollectionAssert.AreEqual(new List<int> {2}, Prime.GetPrimes(2));
    }

    [TestMethod]
    public void GetPrimes_ReturnArrayOfPrimesUpToMax_IntArray()
    {
      CollectionAssert.AreEqual(new List<int> {2, 3, 5, 7}, Prime.GetPrimes(10));
    }
  }
}