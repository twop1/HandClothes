using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary3;
namespace HandClothes
{

    public partial class Form1 : Form
    {
        public static int X = 30;
        public static int Y = -40;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeMyGroupBox(int x, int y, String title, int countInPack, String unit, double? countInStock, String image_path)
        {
            // Create and initialize a GroupBox and a Button control.
            GroupBox groupBox1 = new GroupBox();

            // Create image.
            if (image_path == null || image_path.Equals("")) image_path = "pic.png";
            //else image_path = "D:/4ИС/DbData/materials_s_import/materials/" + image_path.Substring(11);
            Image newImage = Image.FromFile(image_path);

            PictureBox picture = new PictureBox();
            picture.Image = newImage;
            picture.Location = new Point(20, 10);
            picture.Width = 200;
            picture.SizeMode = PictureBoxSizeMode.Zoom;

            //TODO get material type
            Label lb_title = new Label();
            lb_title.Text = "Тип материала | " + title;
            lb_title.Location = new Point(200, 10);
            lb_title.Width = 150;

            //TODO min quontity
            Label lb_countInPack = new Label();
            lb_countInPack.Text = "Минимальное количество: " + countInPack.ToString() + " " + unit;
            lb_countInPack.Location = new Point(200, 35);
            lb_countInPack.Width = 250;

            //TODO rename
            Label lb_unit = new Label();
            lb_unit.Text = "Поставщики: SOMETEXT";
            lb_unit.Location = new Point(200, 60);
            lb_unit.Width = 250;

            Label lb_countInStock = new Label();
            lb_countInStock.Text = "Остаток: " + countInStock.ToString() + " " + unit;
            lb_countInStock.Location = new Point(550, 10);
            lb_countInStock.Width = 100;

            groupBox1.Height = 100;
            groupBox1.Width = 700;

            // Add the Button to the GroupBox.
            groupBox1.Controls.Add(lb_title);
            groupBox1.Controls.Add(lb_countInPack);
            groupBox1.Controls.Add(lb_unit);
            groupBox1.Controls.Add(lb_countInStock);
            groupBox1.Controls.Add(picture);
           
            groupBox1.Location = new Point(x, y);
            

            // Add the GroupBox to the Form.
            Controls.Add(groupBox1);
        }
    

    private async void Form1_Load(object sender, EventArgs e)
    {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet3.Material1". При необходимости она может быть перемещена или удалена.
            this.material1TableAdapter.Fill(this.examDemoDBDataSet3.Material1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.examDemoDBDataSet.MaterialType);

            using (Model1 db = new Model1())
            {
                // Отложенный запрос
                var materials = db.Material1;
                int count = 1;
                // Извлечь всех заказчиков и отобразить их имена в консоли
               
                foreach (Material1 materialObj in materials)
                {
                    if(count <= 5)
                        InitializeMyGroupBox(X, Y + 100 * count, materialObj.Title, materialObj.CountInPack, materialObj.Unit, materialObj.CountInStock, materialObj.Image);
               
                    count++;
                }
                double res = 0;
                Class1 class1 = new Class1();
                for(int i = 0; i< dataGridView1.Rows.Count; i++)
                    dataGridView1[10,i].Value = Convert.ToString(class1.SkladPrice(Convert.ToInt32(dataGridView1[4, i].Value),
                        Convert.ToDouble(dataGridView1[7, i].Value)));

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    res += Convert.ToDouble(dataGridView1[10, j].Value);
                label1.Text = res.ToString();
               

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private  void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            switch (comboBox2.SelectedIndex)
            {
              

                    case 0: { material1BindingSource.Filter = "[Title] = 'Краска'"; break; }
                    case 1: { material1BindingSource.Filter = "[Title] = 'Резина'"; break; }
                    case 2: { material1BindingSource.Filter = "[Title] = 'Силикон'"; break; }

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: { material1BindingSource.Sort = "[Title] DESC"; break; }
                case 1: { material1BindingSource.Sort = "[Title] ASC"; break; }
                    // case 1: { //materialTypeBindingSource1.Sort = "[Title]"; break }

                

            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void examDemoDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void materialTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialTypeTableAdapter.FillBy(this.examDemoDBDataSet.MaterialType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialTypeTableAdapter.FillBy2(this.examDemoDBDataSet.MaterialType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                // Отложенный запрос
                var materials = db.Material1;
                int count = 1;
                // Извлечь всех заказчиков и отобразить их имена в консоли

                foreach (Material1 materialObj in materials)
                {
                    InitializeMyGroupBox(X, Y + 100 * count, materialObj.Title, materialObj.CountInPack, materialObj.Unit, materialObj.CountInStock, materialObj.Image);

                    count++;
                }
            }
        }
    }
}
