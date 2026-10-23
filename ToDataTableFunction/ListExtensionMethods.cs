using System.Data;

namespace ToDataTableFunction
{
    public static class ListExtensionMethods
    {
        public static DataTable ToDataTable(this List<object> list)
        {
            var dataTable = new DataTable();

            var itemProperties = list[0].GetType().GetProperties();

            foreach (var property in itemProperties)
                dataTable.Columns.Add(property.Name.ToString());

            foreach (var item in list)
            {
                List<string> row = new List<string>();

                foreach (var column in dataTable.Columns)
                {
                    var key = item
                                .GetType().GetProperties()
                                .Where(x => x.Name == column.ToString()).First().GetValue(item);

                    row.Add(key?.ToString() ?? "");
                }

                dataTable.Rows.Add(row.ToArray());
            }

            return dataTable;
        }
    }
}
