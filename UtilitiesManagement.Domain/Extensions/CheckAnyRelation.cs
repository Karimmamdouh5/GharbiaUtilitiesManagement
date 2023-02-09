
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstMyApp.Domain.Extensions
{
    public static class CheckAnyRelation
    {
      
        private static object GetEntityFieldValue(this object entityObj, string propertyName)
        {
            var pro = entityObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).First(x => x.Name == propertyName);
            return pro.GetValue(entityObj, null);
        }

        private  static IEnumerable<PropertyInfo> GetManyRelatedEntityNavigatorProperties(object entityObj)
        {
            var props = entityObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(x => x.CanWrite && x.GetGetMethod().IsVirtual /*&& x.PropertyType.IsGenericType == true*/);
            return props;
        }

        public static bool HasAnyRelation(object entityObj)
        {
            var collectionProps = GetManyRelatedEntityNavigatorProperties(entityObj);
            foreach (var item in collectionProps)
            {
                var collectionValue = GetEntityFieldValue(entityObj, item.Name);
                if (collectionValue != null && collectionValue is IEnumerable)
                {
                    var col = collectionValue as IEnumerable;
                    if (col.GetEnumerator().MoveNext())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
