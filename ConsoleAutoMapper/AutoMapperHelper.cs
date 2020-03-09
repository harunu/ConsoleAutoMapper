using System;
using System.Linq;
using System.Reflection;

namespace ConsoleAutoMapper
{
    public static class AutoMapperHelper
    {
        public static P ObjectMap<T, P>(this T objParam, P outParam) where T : class, new()
        {
            Type type = objParam.GetType();
            PropertyInfo[] arrPropertInfo = type.GetProperties();
            Type typeOut = typeof(P);

            PropertyInfo propertyInfo;
            object value;

            foreach (PropertyInfo ItemPropertyInfo in arrPropertInfo)
            {
                value = ItemPropertyInfo.GetValue(objParam, null);
                propertyInfo = typeOut.GetProperties().Where(p => p.Name == ItemPropertyInfo.Name).FirstOrDefault();
                
                if (propertyInfo != null)
                    propertyInfo.SetValue(outParam, value);
            }
            return outParam;
        }
    }
}