namespace PureCloudPlatform.Client.V2.Extensions
{
    using System.Reflection;

    /// <summary>
    /// Safe Property Access
    /// </summary>
    public static class ReflectionUtils
    {
        /// <summary>
        /// Gets property value.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetSafePropertyValue(object obj, string propertyName)
        {
            var type = obj.GetType();
            var properties = type.GetProperties()
                .Where(p => p.Name == propertyName)
                .ToList();

            if (properties.Count == 1)
            {
                return properties[0].GetValue(obj);
            }

            // Handle the case where multiple properties match
            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                if (value != null)
                {
                    return value;
                }
            }

            return null;
        }
    }

}
