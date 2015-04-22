using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace SampleNugetLib.Tests
{
    [TestClass]
    public class SerializerTests
    {
        [TestMethod]
        public void CheckForProperty()
        {
            string propertyName = "Url";
            string testValue = "http://durgha.com";
            var person = new Person {Name = "Gordon", Age = 21, EmailAddress = "gordon@durgha.com"};
            string jsonData = JsonWrapper.SeralizeObject(person, propertyName, testValue);

            // check if custom property was added
            var returnedObj = JObject.Parse(jsonData);
            var customPropertyValue = returnedObj[propertyName];

            Assert.IsNotNull(customPropertyValue);
        }
    }
}
