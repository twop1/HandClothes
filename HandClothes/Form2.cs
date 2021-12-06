using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;


namespace HandClothes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = examDemoDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                //await sqlConnection.OpenAsync();

                SqlCommand command = new SqlCommand("insert into [Material1]  (Title, CountInPack, Unit, CountInStock, MinCount, Description, Cost, Image, MaterialTypeID) values  (@titleNew, @countInPackNew, @UnitNew, @CountInStockNew, @MinCountNew, @DescriptionNew, @CostNew, @ImageNew, @MaterialTypeIDNew);", sqlConnection);
                //command.Parameters.Add("IDNew",SqlDbType.Int).Value = textBox10.Text;
                command.Parameters.Add("titleNew", SqlDbType.NVarChar).Value = textBox1.Text;
                command.Parameters.Add("countInPackNew", SqlDbType.Int).Value = textBox2.Text;
                command.Parameters.Add("UnitNew", SqlDbType.NVarChar).Value = textBox3.Text;
                command.Parameters.Add("CountInStockNew", SqlDbType.Float).Value = textBox4.Text;
                command.Parameters.Add("MinCountNew", SqlDbType.Float).Value = textBox5.Text;
                command.Parameters.Add("DescriptionNew", SqlDbType.NVarChar).Value = textBox6.Text;
                command.Parameters.Add("CostNew", SqlDbType.Decimal).Value = textBox7.Text;
                command.Parameters.Add("ImageNew", SqlDbType.NVarChar).Value = textBox8.Text;
                command.Parameters.Add("MaterialTypeIDNew", SqlDbType.Int).Value = comboBox1.SelectedIndex;
                command.ExecuteNonQuery();

                sqlConnection.Close();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show("ERORR!");
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDemoDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet1.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.examDemoDBDataSet1.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
