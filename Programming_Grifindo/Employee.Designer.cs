namespace Programming_Grifindo
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmonsal = new System.Windows.Forms.TextBox();
            this.txtallow = new System.Windows.Forms.TextBox();
            this.txtot = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empdatagrid = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlysalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindotoysDataSet = new Programming_Grifindo.GrifindotoysDataSet();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new Programming_Grifindo.GrifindotoysDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 53);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Allowence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "OT Rate";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(276, 193);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(474, 30);
            this.txtempid.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(276, 242);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(474, 30);
            this.txtname.TabIndex = 13;
            // 
            // txtmonsal
            // 
            this.txtmonsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonsal.Location = new System.Drawing.Point(276, 286);
            this.txtmonsal.Name = "txtmonsal";
            this.txtmonsal.Size = new System.Drawing.Size(474, 30);
            this.txtmonsal.TabIndex = 14;
            // 
            // txtallow
            // 
            this.txtallow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallow.Location = new System.Drawing.Point(276, 337);
            this.txtallow.Name = "txtallow";
            this.txtallow.Size = new System.Drawing.Size(474, 30);
            this.txtallow.TabIndex = 15;
            // 
            // txtot
            // 
            this.txtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtot.Location = new System.Drawing.Point(276, 389);
            this.txtot.Name = "txtot";
            this.txtot.Size = new System.Drawing.Size(474, 30);
            this.txtot.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // empdatagrid
            // 
            this.empdatagrid.AutoGenerateColumns = false;
            this.empdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.monthlysalDataGridViewTextBoxColumn,
            this.allowenceDataGridViewTextBoxColumn,
            this.oTRateDataGridViewTextBoxColumn});
            this.empdatagrid.DataSource = this.employeeBindingSource;
            this.empdatagrid.Location = new System.Drawing.Point(64, 510);
            this.empdatagrid.Name = "empdatagrid";
            this.empdatagrid.RowHeadersWidth = 51;
            this.empdatagrid.RowTemplate.Height = 24;
            this.empdatagrid.Size = new System.Drawing.Size(1053, 200);
            this.empdatagrid.TabIndex = 18;
            this.empdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empdatagrid_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlysalDataGridViewTextBoxColumn
            // 
            this.monthlysalDataGridViewTextBoxColumn.DataPropertyName = "Monthly_sal";
            this.monthlysalDataGridViewTextBoxColumn.HeaderText = "Monthly_sal";
            this.monthlysalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthlysalDataGridViewTextBoxColumn.Name = "monthlysalDataGridViewTextBoxColumn";
            this.monthlysalDataGridViewTextBoxColumn.Width = 125;
            // 
            // allowenceDataGridViewTextBoxColumn
            // 
            this.allowenceDataGridViewTextBoxColumn.DataPropertyName = "Allowence";
            this.allowenceDataGridViewTextBoxColumn.HeaderText = "Allowence";
            this.allowenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allowenceDataGridViewTextBoxColumn.Name = "allowenceDataGridViewTextBoxColumn";
            this.allowenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // oTRateDataGridViewTextBoxColumn
            // 
            this.oTRateDataGridViewTextBoxColumn.DataPropertyName = "OT_Rate";
            this.oTRateDataGridViewTextBoxColumn.HeaderText = "OT_Rate";
            this.oTRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oTRateDataGridViewTextBoxColumn.Name = "oTRateDataGridViewTextBoxColumn";
            this.oTRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.grifindotoysDataSet;
            // 
            // grifindotoysDataSet
            // 
            this.grifindotoysDataSet.DataSetName = "GrifindotoysDataSet";
            this.grifindotoysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btninsert.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsert.Location = new System.Drawing.Point(276, 443);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(114, 40);
            this.btninsert.TabIndex = 19;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.RosyBrown;
            this.btnback.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(821, 443);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(114, 40);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnupdate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Location = new System.Drawing.Point(396, 443);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(114, 40);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndlt
            // 
            this.btndlt.BackColor = System.Drawing.Color.LimeGreen;
            this.btndlt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndlt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndlt.Location = new System.Drawing.Point(516, 443);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(114, 40);
            this.btndlt.TabIndex = 22;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = false;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsearch.Location = new System.Drawing.Point(636, 443);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(114, 40);
            this.btnsearch.TabIndex = 23;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 117);
            this.panel1.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Stencil Std", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(217, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 57);
            this.label8.TabIndex = 24;
            this.label8.Text = "Grifindo Toys";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1177, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.empdatagrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtot);
            this.Controls.Add(this.txtallow);
            this.Controls.Add(this.txtmonsal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmonsal;
        private System.Windows.Forms.TextBox txtallow;
        private System.Windows.Forms.TextBox txtot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView empdatagrid;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnsearch;
        private GrifindotoysDataSet grifindotoysDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GrifindotoysDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlysalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}