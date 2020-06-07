using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace TsBlog.Repositories
{
    public static class DataConverter
    {
        public static List<T> ToList<T>(this DataTable table) where T : class, new()
        {
            var obj = new T();
            var tType = obj.GetType();
            var list = new List<T>();

            //Define whta attribute to be read form the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            // Read Attribute Names and type
            var objFieldNames = typeof(T).GetProperties(flags)
                .Select(item => new
                {
                    item.Name,
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType

                }).ToList();

            // Read dataTable column names and types
            var dtlFieldNames = table.Columns.Cast<DataColumn>()
                .Select(item => new
                {
                    Name = item.ColumnName,
                    Type = item.DataType

                }).ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {
                foreach (var prop in objFieldNames) 
                {
                    if (!dtlFieldNames.Any(x => x.Name.Equals(prop.Name, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        continue;
                    }
                    var propertyInfo = tType.GetProperty(prop.Name);
                    var rowValue = row[prop.Name];
                    if (propertyInfo == null) continue;
                    var t = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
                    var safeValue = (rowValue == null || DBNull.Value.Equals(rowValue)) ? null : Convert.ChangeType(rowValue, t);
                    propertyInfo.SetValue(obj, safeValue, null);
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
