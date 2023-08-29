//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="OverSys.NET">
// Author: "Team OverSys.NET">
// Copyright (c) OverSys.NET. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
using NUnit.Framework;

namespace NuGet.Workflow.Tests {

   public class UnitTest1 {

      #region methods
      [Test]
      public void Test1() {
         Class1 class1 = new Class1();

         Assert.That(class1.Value, Is.EqualTo("Foo"));
      }
      #endregion
   }

}
