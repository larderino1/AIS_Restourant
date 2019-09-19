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
    public partial class AddItem : Form
    {
        private Main obj = (Main)Application.OpenForms["Main"];
        public AddItem()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
        OleDbConnection _connector = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oksan\Desktop\AISforC#.mdb");

        string query = "insert into Order_lines (order_id, product_id) values (@order_ID, @product_ID);";
            OleDbCommand cmd =  new OleDbCommand(query, _connector);
            OleDbDataReader dr;
            try
            {
                int order_id = comboBox1.SelectedIndex;
                int product_id = comboBox2.SelectedIndex;
                _connector.Open();
                cmd.Parameters.AddWithValue("@order_ID", order_id);
                cmd.Parameters.AddWithValue("@product_ID", product_id);
                dr = cmd.ExecuteReader();
                obj.grid_view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connector.Close();
                _connector.Dispose();
            }
        }
        // order_id
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string order_id = comboBox1.SelectedText;
        }
        // product_name
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product_name = comboBox2.SelectedText;
        }

        private void FillComboBox()
        {
        OleDbConnection _connector = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oksan\Desktop\AISforC#.mdb");

        DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            try
            {
                _connector.Open();
                OleDbCommand cmd1 = new OleDbCommand("select product_ID,product_name from Food group by product_id, product_name", _connector);
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = cmd1;
                da1.Fill(ds1);
                comboBox2.DisplayMember = "product_name";
                comboBox2.ValueMember = "product_ID";
                comboBox2.DataSource = ds1.Tables[0];

                OleDbCommand cmd2 = new OleDbCommand("select order_id from Orders group by order_ID", _connector);
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(ds2);
                comboBox1.DisplayMember = "order_ID";
                comboBox1.ValueMember = "order_ID";
                comboBox1.DataSource = ds2.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                _connector.Close();
                _connector.Dispose();
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}
