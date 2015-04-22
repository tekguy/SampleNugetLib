using Newtonsoft.Json.Linq;

namespace SampleNugetLib
{
    public static class JsonWrapper
    {
        public static string SeralizeObject(object obj, string customPropertyName, string customPropertyValue)
        {
            var jObject = JObject.FromObject(obj);
            jObject.Add(customPropertyName, customPropertyValue);
            return jObject.ToString();
        }
    }
}