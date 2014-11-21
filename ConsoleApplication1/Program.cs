using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            dt.Columns.Add("firstName");
            dt.Columns.Add("lastName");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            dt.Rows.Add("Prashant", "Mohite");
            ds.Tables.Add(dt);
            var dt1 = new DataTable();



            dt1 = ds.Tables[0];
            dt1.DefaultView.ToTable(true, "firstName");

            DataRow [] row= ds.Tables[0].Select("firstname='Prashant'");

        }
    }
}
