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
        private CordBloodUnit unit = new CordBloodUnit();
        
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

        private void AssertDisplayableAttribute(string propertyName, Type domainType, Type attrType, string expectedDataFormat)
        {
            var prop = domainType.GetProperty(propertyName);
            Assert.IsTrue(Attribute.IsDefined(prop, attrType), string.Format("{0} did not have DisplayFormatAttribute", propertyName));
            var formatString = (prop.GetCustomAttributes(attrType, false)[0] as DisplayFormatAttribute).DataFormatString;
            Assert.AreEqual(expectedDataFormat, formatString);
        }
    }
}
