using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercises.Tests
{
    public class PropertyValidator
    {
        internal static void ValidateReadOnly(PropertyInfo prop, string name, Type dataType)
        {
            Assert.IsNotNull(prop, $"{name} property does not exist");
            Assert.IsFalse(prop.CanWrite, $"{name} should not have a set accessor.");
            Assert.IsTrue(prop.CanRead, $"{name} property needs a get accessor.");
            Assert.AreEqual(dataType, prop.PropertyType, $"{name} should be an {dataType.Name}");
        }

        internal static void ValidateReadWrite(PropertyInfo prop, string name, Type dataType)
        {
            Assert.IsNotNull(prop, $"{name} property does not exist");
            Assert.IsTrue(prop.CanWrite, $"{name} should have a set accessor.");
            Assert.IsTrue(prop.CanRead, $"{name} property needs a get accessor.");
            Assert.AreEqual(dataType, prop.PropertyType, $"{name} should be an {dataType.Name}");
        }
    }
}
