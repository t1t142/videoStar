﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar
{
    public static class Convert
    {
       
        public static DataTable ConvertToDataTable<T>(this IEnumerable<T> data)
        {
            List<IDataRecord> list = data.Cast<IDataRecord>().ToList();

            PropertyDescriptorCollection props = null;
            DataTable table = new DataTable();
            if (list != null && list.Count > 0)
            {
                props = TypeDescriptor.GetProperties(list[0]);
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
            }
            if (props != null)
            {
                object[] values = new object[props.Count];
                foreach (T item in data)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = props[i].GetValue(item) ?? DBNull.Value;
                    }
                    table.Rows.Add(values);
                }
            }
            return table;
        }

       
    }
}



