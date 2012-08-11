using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Jeevan.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeevan.Tests.Models
{
    [TestClass]
    public class CordBloodUnitTest
    {
        private CordBloodUnit unit;

        [TestInitialize]
        public void Setup()
        { 
            unit = new CordBloodUnit(){HLA_A1 = 1, HLA_A2 = 1, HLA_B1 = 2, HLA_B2 = 2, DRB_1 = 3, DRB_2 = 3};
        }
        
        [TestMethod]
        public void Should_Have_D2_Display_Format_Property()
        {
            AssertDisplayableAttribute("HLA_A1", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("HLA_A2", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("HLA_B1", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("HLA_B2", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("HLA_C1", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("HLA_C2", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");

            AssertDisplayableAttribute("DRB_1", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("DRB_2", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("DQB_1", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
            AssertDisplayableAttribute("DQB_2", typeof(CordBloodUnit), typeof(DisplayFormatAttribute), "{0:D2}");
        }

        [TestMethod]
        public void ShouldGetMatchCount()
        {
            var other = new CordBloodUnit() { HLA_A1 = 1, HLA_A2 = null, HLA_B1 = 2, HLA_B2 = 2, DRB_1 = 3, DRB_2 = 3 };
            int result = unit.GetMatchCount(other);
            Assert.AreEqual(5, result);
        }

        private void AssertDisplayableAttribute(string propertyName, Type domainType, Type attrType, string expectedDataFormat)
        {
            var prop = domainType.GetProperty(propertyName);
            Assert.IsTrue(Attribute.IsDefined(prop, attrType), string.Format("{0} did not have DisplayFormatAttribute", propertyName));
            var formatString = (prop.GetCustomAttributes(attrType, false)[0] as DisplayFormatAttribute).DataFormatString;
            Assert.AreEqual(expectedDataFormat, formatString);
        }
    }
}
