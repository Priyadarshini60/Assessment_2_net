namespace WindowsFormAssessment2
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.newEmployeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cDACDataSet = new WindowsFormAssessment2.CDACDataSet();
            this.newEmployeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.newEmployeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.newEmployeeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAge = new System.Windows.Forms.TextBox();
            this.newEmployeeBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.newEmployeeBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSal = new System.Windows.Forms.TextBox();
            this.newEmployeeBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.newEmployeeBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtInsert = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.cDACDataSet1 = new WindowsFormAssessment2.CDACDataSet1();
            this.newEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.new_EmployeeTableAdapter = new WindowsFormAssessment2.CDACDataSet1TableAdapters.New_EmployeeTableAdapter();
            this.newEmployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.new_EmployeeTableAdapter1 = new WindowsFormAssessment2.CDACDataSetTableAdapters.New_EmployeeTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.newEmployeeBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.newEmployeeBindingSource11 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource2, "EmpName", true));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource3, "EmpName", true));
            this.txtName.Location = new System.Drawing.Point(144, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newEmployeeBindingSource2
            // 
            this.newEmployeeBindingSource2.DataMember = "New_Employee";
            this.newEmployeeBindingSource2.DataSource = this.cDACDataSet;
            // 
            // cDACDataSet
            // 
            this.cDACDataSet.DataSetName = "CDACDataSet";
            this.cDACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newEmployeeBindingSource3
            // 
            this.newEmployeeBindingSource3.DataMember = "New_Employee";
            this.newEmployeeBindingSource3.DataSource = this.cDACDataSet;
            // 
            // txtDesign
            // 
            this.txtDesign.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource4, "EmpDesignation", true));
            this.txtDesign.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource5, "EmpDesignation", true));
            this.txtDesign.Location = new System.Drawing.Point(144, 119);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(177, 20);
            this.txtDesign.TabIndex = 5;
            // 
            // newEmployeeBindingSource4
            // 
            this.newEmployeeBindingSource4.DataMember = "New_Employee";
            this.newEmployeeBindingSource4.DataSource = this.cDACDataSet;
            // 
            // newEmployeeBindingSource5
            // 
            this.newEmployeeBindingSource5.DataMember = "New_Employee";
            this.newEmployeeBindingSource5.DataSource = this.cDACDataSet;
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource6, "Age", true));
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource7, "Age", true));
            this.txtAge.Location = new System.Drawing.Point(144, 179);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(177, 20);
            this.txtAge.TabIndex = 6;
            // 
            // newEmployeeBindingSource6
            // 
            this.newEmployeeBindingSource6.DataMember = "New_Employee";
            this.newEmployeeBindingSource6.DataSource = this.cDACDataSet;
            // 
            // newEmployeeBindingSource7
            // 
            this.newEmployeeBindingSource7.DataMember = "New_Employee";
            this.newEmployeeBindingSource7.DataSource = this.cDACDataSet;
            // 
            // txtSal
            // 
            this.txtSal.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource8, "Salary", true));
            this.txtSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource9, "Salary", true));
            this.txtSal.Location = new System.Drawing.Point(144, 240);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(177, 20);
            this.txtSal.TabIndex = 7;
            // 
            // newEmployeeBindingSource8
            // 
            this.newEmployeeBindingSource8.DataMember = "New_Employee";
            this.newEmployeeBindingSource8.DataSource = this.cDACDataSet;
            // 
            // newEmployeeBindingSource9
            // 
            this.newEmployeeBindingSource9.DataMember = "New_Employee";
            this.newEmployeeBindingSource9.DataSource = this.cDACDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 225);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(43, 313);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 9;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(144, 313);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(75, 23);
            this.txtUpdate.TabIndex = 10;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(246, 313);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 11;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // cDACDataSet1
            // 
            this.cDACDataSet1.DataSetName = "CDACDataSet1";
            this.cDACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newEmployeeBindingSource
            // 
            this.newEmployeeBindingSource.DataMember = "New_Employee";
            this.newEmployeeBindingSource.DataSource = this.cDACDataSet1;
            // 
            // new_EmployeeTableAdapter
            // 
            this.new_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // newEmployeeBindingSource1
            // 
            this.newEmployeeBindingSource1.DataMember = "New_Employee";
            this.newEmployeeBindingSource1.DataSource = this.cDACDataSet1;
            // 
            // new_EmployeeTableAdapter1
            // 
            this.new_EmployeeTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search by Name";
            // 
            // txtSearch
            // 
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource10, "EmpName", true));
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource11, "EmpName", true));
            this.txtSearch.Location = new System.Drawing.Point(510, 322);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // newEmployeeBindingSource10
            // 
            this.newEmployeeBindingSource10.DataMember = "New_Employee";
            this.newEmployeeBindingSource10.DataSource = this.cDACDataSet;
            // 
            // newEmployeeBindingSource11
            // 
            this.newEmployeeBindingSource11.DataMember = "New_Employee";
            this.newEmployeeBindingSource11.DataSource = this.cDACDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 392);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newEmployeeBindingSource, "Salary", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newEmployeeBindingSource1, "Salary", true));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBindingSource11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtDelete;
        private CDACDataSet1 cDACDataSet1;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource;
        private CDACDataSet1TableAdapters.New_EmployeeTableAdapter new_EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource1;
        private CDACDataSet cDACDataSet;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource2;
        private CDACDataSetTableAdapters.New_EmployeeTableAdapter new_EmployeeTableAdapter1;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource3;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource4;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource5;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource6;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource7;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource8;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource10;
        private System.Windows.Forms.BindingSource newEmployeeBindingSource11;
    }
}

