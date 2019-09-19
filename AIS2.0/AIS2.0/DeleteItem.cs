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
    public partial class DeleteItem : Form
    {
        private Main obj = (Main)Application.OpenForms["Main"];
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection _connector = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oksan\Desktop\AISforC#.mdb");


        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            FillComboBox();

        }
        private void FillComboBox()
        {
            OleDbConnection _connector = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oksan\Desktop\AISforC#.mdb");

            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            try
            {
                _connector.Open();
                OleDbCommand cmd1 = new OleDbCommand("select product_ID,product_name from Order_lines group by product_id, product_name", _connector);
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

    }
}
