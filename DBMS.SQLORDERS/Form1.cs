using System.Data;
using Microsoft.Data.SqlClient;

namespace DBMS.SQLORDERS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void connectDB()
        {
            string server = @"ADM403-33\SQLEXPRESS";
            string db = "Northwind";
            string strCon = string.Format(@"Data Source={0}; Initial Catalog={1};"
                      + "Integrated Security=True;Encrypt=False", server, db);
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        private void disconnectDB()
        {
            conn.Close();
        }

        private void showdata(string sql, DataGridView dgv)
        {
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            connectDB();
            string sqlQuery = "Select o.OrderID, Format(o.OrderDate,'dd-MMM-yyyy') as Order_Date , "
                             + " Format(o.ShippedDate,'dd-MMM-yyyy') as Shipped_Date, "
                             + " sh.CompanyName, TitleOfCourtesy+firstname + ' ' + LastName EmployeeName, "
                             + " c.CompanyName, c.Phone,"
                             + " Convert(decimal(10,2),sum(od.Quantity * od.UnitPrice *(1-od.Discount))) TotalCash"
                             + " from orders o join [Order Details] od on o.OrderID = od.OrderID"
                             + " join Shippers sh on sh.ShipperID = o.ShipVia"
                             + " join Employees e on o.EmployeeID = e.EmployeeID"
                             + " join Customers c on o.CustomerID = c.CustomerID"
                             + " group by o.OrderID, o.OrderDate, o.ShippedDate, sh.CompanyName, "
                             + " TitleOfCourtesy+firstname + ' ' + LastName, c.CompanyName, c.Phone";
            showdata(sqlQuery, dgvOrders);
        }

        private void dgvOrders_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                {
                    int id = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
                    string sqlQuarry = "select p.ProductID, p.ProductName, od.Quantity, od.UnitPrice, od.Discount," +
                        " od.Quantity * od.UnitPrice ¬Õ¥‡ß‘π‡µÁ¡, od.Quantity * od.UnitPrice * od.Discount  Ë«π≈¥," +
                        " od.Quantity * od.UnitPrice * (1-od.Discount) ¬Õ¥‡ß‘π∑’ËÀ—° Ë«π≈¥·≈È«" +
                        " from Orders o join [Order Details] od on o.OrderID = od.OrderID " +
                        " join Products p on od.ProductID = p.ProductID\r\nwhere o.OrderID = @id";
                    cmd = new SqlCommand(sqlQuarry, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvDetails.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
