namespace HandClothes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDemoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDemoDBDataSet = new HandClothes.examDemoDBDataSet();
            this.materialTypeTableAdapter = new HandClothes.examDemoDBDataSetTableAdapters.MaterialTypeTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.examDemoDBDataSet1 = new HandClothes.examDemoDBDataSet();
            this.materialTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTypeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.examDemoDBDataSet21 = new HandClothes.examDemoDBDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countInPackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDemoDBDataSet3 = new HandClothes.examDemoDBDataSet3();
            this.material1TableAdapter = new HandClothes.examDemoDBDataSet3TableAdapters.Material1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Наименование(по возрастанию)",
            "Наименование(по убыванию)"});
            this.comboBox1.Location = new System.Drawing.Point(540, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Сортировка";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Краска",
            "Резина",
            "Силикон"});
            this.comboBox2.Location = new System.Drawing.Point(753, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Фильтрация";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialTypeBindingSource
            // 
            this.materialTypeBindingSource.DataMember = "MaterialType";
            this.materialTypeBindingSource.DataSource = this.examDemoDBDataSetBindingSource;
            this.materialTypeBindingSource.CurrentChanged += new System.EventHandler(this.materialTypeBindingSource_CurrentChanged);
            // 
            // examDemoDBDataSetBindingSource
            // 
            this.examDemoDBDataSetBindingSource.DataSource = this.examDemoDBDataSet;
            this.examDemoDBDataSetBindingSource.Position = 0;
            this.examDemoDBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.examDemoDBDataSetBindingSource_CurrentChanged);
            // 
            // examDemoDBDataSet
            // 
            this.examDemoDBDataSet.DataSetName = "examDemoDBDataSet";
            this.examDemoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTypeTableAdapter
            // 
            this.materialTypeTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.materialTypeBindingSource1;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged_1);
            // 
            // materialTypeBindingSource1
            // 
            this.materialTypeBindingSource1.DataMember = "MaterialType";
            this.materialTypeBindingSource1.DataSource = this.examDemoDBDataSetBindingSource;
            // 
            // materialTypeBindingSource2
            // 
            this.materialTypeBindingSource2.DataMember = "MaterialType";
            this.materialTypeBindingSource2.DataSource = this.examDemoDBDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1219, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // examDemoDBDataSet1
            // 
            this.examDemoDBDataSet1.DataSetName = "examDemoDBDataSet";
            this.examDemoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTypeBindingSource3
            // 
            this.materialTypeBindingSource3.DataMember = "MaterialType";
            this.materialTypeBindingSource3.DataSource = this.examDemoDBDataSetBindingSource;
            // 
            // materialTypeBindingSource4
            // 
            this.materialTypeBindingSource4.DataMember = "MaterialType";
            this.materialTypeBindingSource4.DataSource = this.examDemoDBDataSetBindingSource;
            // 
            // examDemoDBDataSet21
            // 
            this.examDemoDBDataSet21.DataSetName = "examDemoDBDataSet2";
            this.examDemoDBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.countInPackDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.countInStockDataGridViewTextBoxColumn,
            this.minCountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.materialTypeIDDataGridViewTextBoxColumn,
            this.UnitSum});
            this.dataGridView1.DataSource = this.material1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(740, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1138, 341);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // countInPackDataGridViewTextBoxColumn
            // 
            this.countInPackDataGridViewTextBoxColumn.DataPropertyName = "CountInPack";
            this.countInPackDataGridViewTextBoxColumn.HeaderText = "CountInPack";
            this.countInPackDataGridViewTextBoxColumn.Name = "countInPackDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // countInStockDataGridViewTextBoxColumn
            // 
            this.countInStockDataGridViewTextBoxColumn.DataPropertyName = "CountInStock";
            this.countInStockDataGridViewTextBoxColumn.HeaderText = "CountInStock";
            this.countInStockDataGridViewTextBoxColumn.Name = "countInStockDataGridViewTextBoxColumn";
            // 
            // minCountDataGridViewTextBoxColumn
            // 
            this.minCountDataGridViewTextBoxColumn.DataPropertyName = "MinCount";
            this.minCountDataGridViewTextBoxColumn.HeaderText = "MinCount";
            this.minCountDataGridViewTextBoxColumn.Name = "minCountDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // materialTypeIDDataGridViewTextBoxColumn
            // 
            this.materialTypeIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialTypeID";
            this.materialTypeIDDataGridViewTextBoxColumn.HeaderText = "MaterialTypeID";
            this.materialTypeIDDataGridViewTextBoxColumn.Name = "materialTypeIDDataGridViewTextBoxColumn";
            // 
            // UnitSum
            // 
            this.UnitSum.HeaderText = "UnitSum";
            this.UnitSum.Name = "UnitSum";
            // 
            // material1BindingSource
            // 
            this.material1BindingSource.DataMember = "Material1";
            this.material1BindingSource.DataSource = this.examDemoDBDataSet3;
            // 
            // examDemoDBDataSet3
            // 
            this.examDemoDBDataSet3.DataSetName = "examDemoDBDataSet3";
            this.examDemoDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // material1TableAdapter
            // 
            this.material1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1095, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(775, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 640);
            this.Name = "Form1";
            this.Text = "   Hand clothes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource examDemoDBDataSetBindingSource;
        private examDemoDBDataSet examDemoDBDataSet;
        private System.Windows.Forms.BindingSource materialTypeBindingSource;
        private examDemoDBDataSetTableAdapters.MaterialTypeTableAdapter materialTypeTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource materialTypeBindingSource1;
        private System.Windows.Forms.BindingSource materialTypeBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private examDemoDBDataSet examDemoDBDataSet1;
        private System.Windows.Forms.BindingSource materialTypeBindingSource3;
        private System.Windows.Forms.BindingSource materialTypeBindingSource4;
        private examDemoDBDataSet2 examDemoDBDataSet21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private examDemoDBDataSet3 examDemoDBDataSet3;
        private System.Windows.Forms.BindingSource material1BindingSource;
        private examDemoDBDataSet3TableAdapters.Material1TableAdapter material1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countInPackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}

