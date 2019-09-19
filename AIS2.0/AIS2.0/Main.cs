using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS2._0
{
    public partial class Main : Form
    {
        private OleDbConnection _connector = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oksan\Desktop\AISforC#.mdb");

        public Main()
        {
            InitializeComponent();
        }

        private void billView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(billView.CurrentCell.Value.ToString());

        }

        private void Main_Load(object sender, EventArgs e)
        {
            grid_view_data();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            AddItem addForm = new AddItem();
            addForm.ShowDialog();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem deleteForm = new DeleteItem();
            deleteForm.ShowDialog();
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.ShowDialog();
        }

        

        public void grid_view_data()
        {
            _connector.Open();
          
            
            OleDbCommand cmd = _connector.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Bill.Check_ID, Bill.order_date, Bill.order_time, sum(product_price) as full_sum, Bill.table_ID " +
                              "FROM(Bill INNER JOIN Orders ON Bill.Check_ID = Orders.check_ID) INNER JOIN(Food INNER JOIN Order_lines " +
                              "ON Food.product_ID = Order_lines.product_ID) ON Orders.order_ID = Order_lines.order_ID" +
                              " where Order_lines.order_ID = Orders.order_ID AND Bill.check_ID = Orders.check_ID" +
                              " GROUP BY Bill.Check_ID, Bill.order_date, Bill.order_time, Bill.table_ID; ";
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(dt);
            billView.DataSource = dt;
            _connector.Close();
        }

        private void printBill_Click(object sender, EventArgs e)
        {
            OrderToPayFrom pay = new OrderToPayFrom();
            pay.ShowDialog();
        }
    }
}
