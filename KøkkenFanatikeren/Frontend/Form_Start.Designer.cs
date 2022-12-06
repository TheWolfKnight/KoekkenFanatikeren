namespace KøkkenFanatikeren.Frontend
{
    partial class Start_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_customerName = new System.Windows.Forms.TextBox();
            this.tb_CustomerID = new System.Windows.Forms.TextBox();
            this.tb_Employe = new System.Windows.Forms.TextBox();
            this.rtb_YourAssignment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_CustomerInfo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenFanaticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenFanaticDataSet = new KøkkenFanatikeren.KitchenFanaticDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_OrderItem = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_ItemCat = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_search = new System.Windows.Forms.Button();
            this.b_CreatNewDoc = new System.Windows.Forms.Button();
            this.b_OpenDoc = new System.Windows.Forms.Button();
            this.b_SaveDoc = new System.Windows.Forms.Button();
            this.b_EditCustomer = new System.Windows.Forms.Button();
            this.customerRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new KøkkenFanatikeren.KitchenFanaticDataSetTableAdapters.CustomersTableAdapter();
            this.orderRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Print = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // tb_customerName
            // 
            this.tb_customerName.Location = new System.Drawing.Point(119, 80);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(126, 22);
            this.tb_customerName.TabIndex = 3;
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Location = new System.Drawing.Point(119, 52);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.Size = new System.Drawing.Size(126, 22);
            this.tb_CustomerID.TabIndex = 4;
            // 
            // tb_Employe
            // 
            this.tb_Employe.Location = new System.Drawing.Point(119, 2);
            this.tb_Employe.Name = "tb_Employe";
            this.tb_Employe.Size = new System.Drawing.Size(126, 22);
            this.tb_Employe.TabIndex = 5;
            // 
            // rtb_YourAssignment
            // 
            this.rtb_YourAssignment.Location = new System.Drawing.Point(12, 232);
            this.rtb_YourAssignment.Name = "rtb_YourAssignment";
            this.rtb_YourAssignment.Size = new System.Drawing.Size(191, 206);
            this.rtb_YourAssignment.TabIndex = 6;
            this.rtb_YourAssignment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Assignment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(209, 213);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 225);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CustomerInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_CustomerInfo
            // 
            this.dgv_CustomerInfo.AutoGenerateColumns = false;
            this.dgv_CustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgv_CustomerInfo.DataSource = this.customersBindingSource;
            this.dgv_CustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CustomerInfo.Location = new System.Drawing.Point(3, 3);
            this.dgv_CustomerInfo.MultiSelect = false;
            this.dgv_CustomerInfo.Name = "dgv_CustomerInfo";
            this.dgv_CustomerInfo.RowHeadersWidth = 51;
            this.dgv_CustomerInfo.RowTemplate.Height = 24;
            this.dgv_CustomerInfo.Size = new System.Drawing.Size(565, 190);
            this.dgv_CustomerInfo.TabIndex = 0;
            this.dgv_CustomerInfo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CustomerInfo_RowEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.kitchenFanaticDataSetBindingSource;
            // 
            // kitchenFanaticDataSetBindingSource
            // 
            this.kitchenFanaticDataSetBindingSource.DataSource = this.kitchenFanaticDataSet;
            this.kitchenFanaticDataSetBindingSource.Position = 0;
            // 
            // kitchenFanaticDataSet
            // 
            this.kitchenFanaticDataSet.DataSetName = "KitchenFanaticDataSet";
            this.kitchenFanaticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Orders);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AutoGenerateColumns = false;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.customerIdDataGridViewTextBoxColumn,
            this.creatorIdDataGridViewTextBoxColumn,
            this.creationDataGridViewTextBoxColumn,
            this.completionDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dgv_Orders.DataSource = this.orderBindingSource;
            this.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Orders.Location = new System.Drawing.Point(3, 3);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.RowHeadersWidth = 51;
            this.dgv_Orders.RowTemplate.Height = 24;
            this.dgv_Orders.Size = new System.Drawing.Size(565, 190);
            this.dgv_Orders.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // creatorIdDataGridViewTextBoxColumn
            // 
            this.creatorIdDataGridViewTextBoxColumn.DataPropertyName = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.HeaderText = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creatorIdDataGridViewTextBoxColumn.Name = "creatorIdDataGridViewTextBoxColumn";
            this.creatorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationDataGridViewTextBoxColumn
            // 
            this.creationDataGridViewTextBoxColumn.DataPropertyName = "Creation";
            this.creationDataGridViewTextBoxColumn.HeaderText = "Creation";
            this.creationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationDataGridViewTextBoxColumn.Name = "creationDataGridViewTextBoxColumn";
            this.creationDataGridViewTextBoxColumn.Width = 125;
            // 
            // completionDataGridViewTextBoxColumn
            // 
            this.completionDataGridViewTextBoxColumn.DataPropertyName = "Completion";
            this.completionDataGridViewTextBoxColumn.HeaderText = "Completion";
            this.completionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.completionDataGridViewTextBoxColumn.Name = "completionDataGridViewTextBoxColumn";
            this.completionDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(KøkkenFanatikeren.Src.Database.Order);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_OrderItem);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(571, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_OrderItem
            // 
            this.dgv_OrderItem.AutoGenerateColumns = false;
            this.dgv_OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgv_OrderItem.DataSource = this.orderItemBindingSource;
            this.dgv_OrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_OrderItem.Location = new System.Drawing.Point(3, 3);
            this.dgv_OrderItem.Name = "dgv_OrderItem";
            this.dgv_OrderItem.RowHeadersWidth = 51;
            this.dgv_OrderItem.RowTemplate.Height = 24;
            this.dgv_OrderItem.Size = new System.Drawing.Size(565, 190);
            this.dgv_OrderItem.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(KøkkenFanatikeren.Src.Database.OrderItem);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_ItemCat);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(571, 196);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Item Categories";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_ItemCat
            // 
            this.dgv_ItemCat.AutoGenerateColumns = false;
            this.dgv_ItemCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgv_ItemCat.DataSource = this.itemCategoryBindingSource;
            this.dgv_ItemCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ItemCat.Location = new System.Drawing.Point(3, 3);
            this.dgv_ItemCat.Name = "dgv_ItemCat";
            this.dgv_ItemCat.RowHeadersWidth = 51;
            this.dgv_ItemCat.RowTemplate.Height = 24;
            this.dgv_ItemCat.Size = new System.Drawing.Size(565, 190);
            this.dgv_ItemCat.TabIndex = 0;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(KøkkenFanatikeren.Src.Database.ItemCategory);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(256, 52);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(106, 24);
            this.b_search.TabIndex = 9;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.B_search_Click);
            // 
            // b_CreatNewDoc
            // 
            this.b_CreatNewDoc.Location = new System.Drawing.Point(362, 12);
            this.b_CreatNewDoc.Name = "b_CreatNewDoc";
            this.b_CreatNewDoc.Size = new System.Drawing.Size(101, 36);
            this.b_CreatNewDoc.TabIndex = 10;
            this.b_CreatNewDoc.Text = "New";
            this.b_CreatNewDoc.UseVisualStyleBackColor = true;
            this.b_CreatNewDoc.Click += new System.EventHandler(this.B_CreatNewDoc_Click);
            // 
            // b_OpenDoc
            // 
            this.b_OpenDoc.Location = new System.Drawing.Point(469, 12);
            this.b_OpenDoc.Name = "b_OpenDoc";
            this.b_OpenDoc.Size = new System.Drawing.Size(105, 36);
            this.b_OpenDoc.TabIndex = 11;
            this.b_OpenDoc.Text = "Open";
            this.b_OpenDoc.UseVisualStyleBackColor = true;
            this.b_OpenDoc.Click += new System.EventHandler(this.B_OpenDuc_Click);
            // 
            // b_SaveDoc
            // 
            this.b_SaveDoc.Location = new System.Drawing.Point(580, 12);
            this.b_SaveDoc.Name = "b_SaveDoc";
            this.b_SaveDoc.Size = new System.Drawing.Size(101, 36);
            this.b_SaveDoc.TabIndex = 12;
            this.b_SaveDoc.Text = "Save";
            this.b_SaveDoc.UseVisualStyleBackColor = true;
            this.b_SaveDoc.Click += new System.EventHandler(this.B_SaveDoc_Click);
            // 
            // b_EditCustomer
            // 
            this.b_EditCustomer.Location = new System.Drawing.Point(687, 12);
            this.b_EditCustomer.Name = "b_EditCustomer";
            this.b_EditCustomer.Size = new System.Drawing.Size(101, 36);
            this.b_EditCustomer.TabIndex = 13;
            this.b_EditCustomer.Text = "Edit";
            this.b_EditCustomer.UseVisualStyleBackColor = true;
            this.b_EditCustomer.Click += new System.EventHandler(this.B_EditCustomer_Click);
            // 
            // customerRepositoryBindingSource
            // 
            this.customerRepositoryBindingSource.DataSource = typeof(KøkkenFanatikeren.Src.Repository.CustomerRepository);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // orderRepositoryBindingSource
            // 
            this.orderRepositoryBindingSource.DataSource = typeof(KøkkenFanatikeren.Src.Repository.OrderRepository);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(687, 54);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(101, 36);
            this.btn_Print.TabIndex = 14;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.b_EditCustomer);
            this.Controls.Add(this.b_SaveDoc);
            this.Controls.Add(this.b_OpenDoc);
            this.Controls.Add(this.b_CreatNewDoc);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_YourAssignment);
            this.Controls.Add(this.tb_Employe);
            this.Controls.Add(this.tb_CustomerID);
            this.Controls.Add(this.tb_customerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start_Menu";
            this.Text = "Q";
            this.Load += new System.EventHandler(this.Form_Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_customerName;
        public System.Windows.Forms.TextBox tb_CustomerID;
        public System.Windows.Forms.TextBox tb_Employe;
        public System.Windows.Forms.RichTextBox rtb_YourAssignment;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button b_search;
        public System.Windows.Forms.Button b_CreatNewDoc;
        public System.Windows.Forms.Button b_OpenDoc;
        public System.Windows.Forms.Button b_SaveDoc;
        public System.Windows.Forms.Button b_EditCustomer;
        private System.Windows.Forms.BindingSource kitchenFanaticDataSetBindingSource;
        private KitchenFanaticDataSet kitchenFanaticDataSet;
        private System.Windows.Forms.DataGridView dgv_CustomerInfo;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private KitchenFanaticDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderRepositoryBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_OrderItem;
        private System.Windows.Forms.BindingSource customerRepositoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_ItemCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        public System.Windows.Forms.Button btn_Print;
    }
}