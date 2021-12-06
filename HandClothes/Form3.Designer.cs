namespace HandClothes
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label countInPackLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label minCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label countInStockLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label materialTypeIDLabel;
            this.examDemoDBDataSet1 = new HandClothes.examDemoDBDataSet1();
            this.material1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material1TableAdapter = new HandClothes.examDemoDBDataSet1TableAdapters.Material1TableAdapter();
            this.tableAdapterManager = new HandClothes.examDemoDBDataSet1TableAdapters.TableAdapterManager();
            this.material1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.material1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.countInPackTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.minCountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.countInStockTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeIDTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            countInPackLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            minCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            countInStockLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            materialTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingNavigator)).BeginInit();
            this.material1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // examDemoDBDataSet1
            // 
            this.examDemoDBDataSet1.DataSetName = "examDemoDBDataSet1";
            this.examDemoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // material1BindingSource
            // 
            this.material1BindingSource.DataMember = "Material1";
            this.material1BindingSource.DataSource = this.examDemoDBDataSet1;
            // 
            // material1TableAdapter
            // 
            this.material1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentPriorityHistoryTableAdapter = null;
            this.tableAdapterManager.AgentTableAdapter = null;
            this.tableAdapterManager.AgentTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Material1TableAdapter = this.material1TableAdapter;
            this.tableAdapterManager.MaterialCountHistoryTableAdapter = null;
            this.tableAdapterManager.MaterialSupplierTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.ProductCostHistoryTableAdapter = null;
            this.tableAdapterManager.ProductMaterialTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HandClothes.examDemoDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // material1BindingNavigator
            // 
            this.material1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.material1BindingNavigator.BindingSource = this.material1BindingSource;
            this.material1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.material1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.material1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.material1BindingNavigatorSaveItem});
            this.material1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.material1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.material1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.material1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.material1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.material1BindingNavigator.Name = "material1BindingNavigator";
            this.material1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.material1BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.material1BindingNavigator.TabIndex = 0;
            this.material1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // material1BindingNavigatorSaveItem
            // 
            this.material1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.material1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("material1BindingNavigatorSaveItem.Image")));
            this.material1BindingNavigatorSaveItem.Name = "material1BindingNavigatorSaveItem";
            this.material1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.material1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.material1BindingNavigatorSaveItem.Click += new System.EventHandler(this.material1BindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(200, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(227, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(191, 119);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(227, 116);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // countInPackLabel
            // 
            countInPackLabel.AutoSize = true;
            countInPackLabel.Location = new System.Drawing.Point(143, 156);
            countInPackLabel.Name = "countInPackLabel";
            countInPackLabel.Size = new System.Drawing.Size(78, 13);
            countInPackLabel.TabIndex = 5;
            countInPackLabel.Text = "Count In Pack:";
            // 
            // countInPackTextBox
            // 
            this.countInPackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "CountInPack", true));
            this.countInPackTextBox.Location = new System.Drawing.Point(227, 153);
            this.countInPackTextBox.Name = "countInPackTextBox";
            this.countInPackTextBox.Size = new System.Drawing.Size(100, 20);
            this.countInPackTextBox.TabIndex = 6;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(192, 205);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "Unit:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(227, 202);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitTextBox.TabIndex = 8;
            // 
            // minCountLabel
            // 
            minCountLabel.AutoSize = true;
            minCountLabel.Location = new System.Drawing.Point(163, 236);
            minCountLabel.Name = "minCountLabel";
            minCountLabel.Size = new System.Drawing.Size(58, 13);
            minCountLabel.TabIndex = 9;
            minCountLabel.Text = "Min Count:";
            // 
            // minCountTextBox
            // 
            this.minCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "MinCount", true));
            this.minCountTextBox.Location = new System.Drawing.Point(227, 233);
            this.minCountTextBox.Name = "minCountTextBox";
            this.minCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.minCountTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(158, 273);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(227, 270);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(190, 299);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 13;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(227, 296);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 14;
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new System.Drawing.Point(140, 179);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new System.Drawing.Size(81, 13);
            countInStockLabel.TabIndex = 15;
            countInStockLabel.Text = "Count In Stock:";
            countInStockLabel.Click += new System.EventHandler(this.countInStockLabel_Click);
            // 
            // countInStockTextBox
            // 
            this.countInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "CountInStock", true));
            this.countInStockTextBox.Location = new System.Drawing.Point(227, 176);
            this.countInStockTextBox.Name = "countInStockTextBox";
            this.countInStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.countInStockTextBox.TabIndex = 16;
            this.countInStockTextBox.TextChanged += new System.EventHandler(this.countInStockTextBox_TextChanged);
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(182, 325);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 17;
            imageLabel.Text = "Image:";
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(227, 322);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageTextBox.TabIndex = 18;
            // 
            // materialTypeIDLabel
            // 
            materialTypeIDLabel.AutoSize = true;
            materialTypeIDLabel.Location = new System.Drawing.Point(133, 362);
            materialTypeIDLabel.Name = "materialTypeIDLabel";
            materialTypeIDLabel.Size = new System.Drawing.Size(88, 13);
            materialTypeIDLabel.TabIndex = 19;
            materialTypeIDLabel.Text = "Material Type ID:";
            // 
            // materialTypeIDTextBox
            // 
            this.materialTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.material1BindingSource, "MaterialTypeID", true));
            this.materialTypeIDTextBox.Location = new System.Drawing.Point(227, 359);
            this.materialTypeIDTextBox.Name = "materialTypeIDTextBox";
            this.materialTypeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialTypeIDTextBox.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(materialTypeIDLabel);
            this.Controls.Add(this.materialTypeIDTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(countInStockLabel);
            this.Controls.Add(this.countInStockTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCountLabel);
            this.Controls.Add(this.minCountTextBox);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(countInPackLabel);
            this.Controls.Add(this.countInPackTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.material1BindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDemoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.material1BindingNavigator)).EndInit();
            this.material1BindingNavigator.ResumeLayout(false);
            this.material1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private examDemoDBDataSet1 examDemoDBDataSet1;
        private System.Windows.Forms.BindingSource material1BindingSource;
        private examDemoDBDataSet1TableAdapters.Material1TableAdapter material1TableAdapter;
        private examDemoDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator material1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton material1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox countInPackTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox minCountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox countInStockTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox materialTypeIDTextBox;
    }
}