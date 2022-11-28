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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kitchenFanaticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenFanaticDataSet = new KøkkenFanatikeren.KitchenFanaticDataSet();
            this.b_search = new System.Windows.Forms.Button();
            this.b_CreatNewDoc = new System.Windows.Forms.Button();
            this.b_OpenDoc = new System.Windows.Forms.Button();
            this.b_SaveDoc = new System.Windows.Forms.Button();
            this.b_EditCustomer = new System.Windows.Forms.Button();
            this.dgv_CustomerInfo = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new KøkkenFanatikeren.KitchenFanaticDataSetTableAdapters.CustomersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // tb_customerName
            // 
            this.tb_customerName.Location = new System.Drawing.Point(123, 50);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(100, 22);
            this.tb_customerName.TabIndex = 3;
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Location = new System.Drawing.Point(123, 78);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.Size = new System.Drawing.Size(100, 22);
            this.tb_CustomerID.TabIndex = 4;
            // 
            // tb_Employe
            // 
            this.tb_Employe.Location = new System.Drawing.Point(123, 6);
            this.tb_Employe.Name = "tb_Employe";
            this.tb_Employe.Size = new System.Drawing.Size(100, 22);
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
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Assignment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(229, 57);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(101, 36);
            this.b_search.TabIndex = 9;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // b_CreatNewDoc
            // 
            this.b_CreatNewDoc.Location = new System.Drawing.Point(12, 114);
            this.b_CreatNewDoc.Name = "b_CreatNewDoc";
            this.b_CreatNewDoc.Size = new System.Drawing.Size(101, 36);
            this.b_CreatNewDoc.TabIndex = 10;
            this.b_CreatNewDoc.Text = "New";
            this.b_CreatNewDoc.UseVisualStyleBackColor = true;
            this.b_CreatNewDoc.Click += new System.EventHandler(this.b_CreatNewDoc_Click);
            // 
            // b_OpenDoc
            // 
            this.b_OpenDoc.Location = new System.Drawing.Point(119, 114);
            this.b_OpenDoc.Name = "b_OpenDoc";
            this.b_OpenDoc.Size = new System.Drawing.Size(105, 36);
            this.b_OpenDoc.TabIndex = 11;
            this.b_OpenDoc.Text = "Open";
            this.b_OpenDoc.UseVisualStyleBackColor = true;
            this.b_OpenDoc.Click += new System.EventHandler(this.b_OpenDuc_Click);
            // 
            // b_SaveDoc
            // 
            this.b_SaveDoc.Location = new System.Drawing.Point(12, 156);
            this.b_SaveDoc.Name = "b_SaveDoc";
            this.b_SaveDoc.Size = new System.Drawing.Size(101, 36);
            this.b_SaveDoc.TabIndex = 12;
            this.b_SaveDoc.Text = "Save";
            this.b_SaveDoc.UseVisualStyleBackColor = true;
            this.b_SaveDoc.Click += new System.EventHandler(this.b_SaveDoc_Click);
            // 
            // b_EditCustomer
            // 
            this.b_EditCustomer.Location = new System.Drawing.Point(123, 156);
            this.b_EditCustomer.Name = "b_EditCustomer";
            this.b_EditCustomer.Size = new System.Drawing.Size(101, 36);
            this.b_EditCustomer.TabIndex = 13;
            this.b_EditCustomer.Text = "Edit";
            this.b_EditCustomer.UseVisualStyleBackColor = true;
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
            this.dgv_CustomerInfo.Name = "dgv_CustomerInfo";
            this.dgv_CustomerInfo.RowHeadersWidth = 51;
            this.dgv_CustomerInfo.RowTemplate.Height = 24;
            this.dgv_CustomerInfo.Size = new System.Drawing.Size(565, 190);
            this.dgv_CustomerInfo.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.kitchenFanaticDataSetBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form_Start";
            this.Load += new System.EventHandler(this.Form_Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
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
    }
}