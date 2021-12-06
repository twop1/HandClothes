using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandClothes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void material1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.material1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDemoDBDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDemoDBDataSet1.Material1". При необходимости она может быть перемещена или удалена.
            this.material1TableAdapter.Fill(this.examDemoDBDataSet1.Material1);

        }

        private void countInStockLabel_Click(object sender, EventArgs e)
        {

        }

        private void countInStockTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
