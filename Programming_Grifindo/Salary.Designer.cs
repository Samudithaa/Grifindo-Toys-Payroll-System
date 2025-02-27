namespace Programming_Grifindo
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.btnback = new System.Windows.Forms.Button();
            this.saldatagrid = new System.Windows.Forms.DataGridView();
            this.salaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarybegindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfLeavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oThoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basepayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosspayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grifindotoysDataSet3 = new Programming_Grifindo.GrifindotoysDataSet3();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtgross = new System.Windows.Forms.TextBox();
            this.txtOThours = new System.Windows.Forms.TextBox();
            this.txtbasep = new System.Windows.Forms.TextBox();
            this.txtsalid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnopay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.grifindotoysDataSet1 = new Programming_Grifindo.GrifindotoysDataSet1();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter = new Programming_Grifindo.GrifindotoysDataSet1TableAdapters.SalaryTableAdapter();
            this.datebegin = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnoleaves = new System.Windows.Forms.TextBox();
            this.grifindotoysDataSet2 = new Programming_Grifindo.GrifindotoysDataSet2();
            this.salaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter1 = new Programming_Grifindo.GrifindotoysDataSet2TableAdapters.SalaryTableAdapter();
            this.salaryTableAdapter2 = new Programming_Grifindo.GrifindotoysDataSet3TableAdapters.SalaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saldatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.RosyBrown;
            this.btnback.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(821, 571);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 40);
            this.btnback.TabIndex = 39;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // saldatagrid
            // 
            this.saldatagrid.AutoGenerateColumns = false;
            this.saldatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saldatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryIDDataGridViewTextBoxColumn,
            this.salarybegindateDataGridViewTextBoxColumn,
            this.salaryenddateDataGridViewTextBoxColumn,
            this.noOfLeavesDataGridViewTextBoxColumn,
            this.oThoursDataGridViewTextBoxColumn,
            this.nopayDataGridViewTextBoxColumn,
            this.basepayDataGridViewTextBoxColumn,
            this.grosspayDataGridViewTextBoxColumn});
            this.saldatagrid.DataSource = this.salaryBindingSource2;
            this.saldatagrid.Location = new System.Drawing.Point(64, 662);
            this.saldatagrid.Name = "saldatagrid";
            this.saldatagrid.RowHeadersWidth = 51;
            this.saldatagrid.RowTemplate.Height = 24;
            this.saldatagrid.Size = new System.Drawing.Size(1053, 200);
            this.saldatagrid.TabIndex = 37;
            this.saldatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saldatagrid_CellContentClick);
            // 
            // salaryIDDataGridViewTextBoxColumn
            // 
            this.salaryIDDataGridViewTextBoxColumn.DataPropertyName = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.HeaderText = "Salary_ID";
            this.salaryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryIDDataGridViewTextBoxColumn.Name = "salaryIDDataGridViewTextBoxColumn";
            this.salaryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarybegindateDataGridViewTextBoxColumn
            // 
            this.salarybegindateDataGridViewTextBoxColumn.DataPropertyName = "Salarybegindate";
            this.salarybegindateDataGridViewTextBoxColumn.HeaderText = "Salarybegindate";
            this.salarybegindateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarybegindateDataGridViewTextBoxColumn.Name = "salarybegindateDataGridViewTextBoxColumn";
            this.salarybegindateDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryenddateDataGridViewTextBoxColumn
            // 
            this.salaryenddateDataGridViewTextBoxColumn.DataPropertyName = "Salaryenddate";
            this.salaryenddateDataGridViewTextBoxColumn.HeaderText = "Salaryenddate";
            this.salaryenddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryenddateDataGridViewTextBoxColumn.Name = "salaryenddateDataGridViewTextBoxColumn";
            this.salaryenddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOfLeavesDataGridViewTextBoxColumn
            // 
            this.noOfLeavesDataGridViewTextBoxColumn.DataPropertyName = "NoOfLeaves";
            this.noOfLeavesDataGridViewTextBoxColumn.HeaderText = "NoOfLeaves";
            this.noOfLeavesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfLeavesDataGridViewTextBoxColumn.Name = "noOfLeavesDataGridViewTextBoxColumn";
            this.noOfLeavesDataGridViewTextBoxColumn.Width = 125;
            // 
            // oThoursDataGridViewTextBoxColumn
            // 
            this.oThoursDataGridViewTextBoxColumn.DataPropertyName = "OT_hours";
            this.oThoursDataGridViewTextBoxColumn.HeaderText = "OT_hours";
            this.oThoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oThoursDataGridViewTextBoxColumn.Name = "oThoursDataGridViewTextBoxColumn";
            this.oThoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nopayDataGridViewTextBoxColumn
            // 
            this.nopayDataGridViewTextBoxColumn.DataPropertyName = "No_pay";
            this.nopayDataGridViewTextBoxColumn.HeaderText = "No_pay";
            this.nopayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nopayDataGridViewTextBoxColumn.Name = "nopayDataGridViewTextBoxColumn";
            this.nopayDataGridViewTextBoxColumn.Width = 125;
            // 
            // basepayDataGridViewTextBoxColumn
            // 
            this.basepayDataGridViewTextBoxColumn.DataPropertyName = "Base_pay";
            this.basepayDataGridViewTextBoxColumn.HeaderText = "Base_pay";
            this.basepayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basepayDataGridViewTextBoxColumn.Name = "basepayDataGridViewTextBoxColumn";
            this.basepayDataGridViewTextBoxColumn.Width = 125;
            // 
            // grosspayDataGridViewTextBoxColumn
            // 
            this.grosspayDataGridViewTextBoxColumn.DataPropertyName = "Grosspay";
            this.grosspayDataGridViewTextBoxColumn.HeaderText = "Grosspay";
            this.grosspayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grosspayDataGridViewTextBoxColumn.Name = "grosspayDataGridViewTextBoxColumn";
            this.grosspayDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryBindingSource2
            // 
            this.salaryBindingSource2.DataMember = "Salary";
            this.salaryBindingSource2.DataSource = this.grifindotoysDataSet3;
            // 
            // grifindotoysDataSet3
            // 
            this.grifindotoysDataSet3.DataSetName = "GrifindotoysDataSet3";
            this.grifindotoysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // txtgross
            // 
            this.txtgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgross.Location = new System.Drawing.Point(276, 521);
            this.txtgross.Name = "txtgross";
            this.txtgross.ReadOnly = true;
            this.txtgross.Size = new System.Drawing.Size(474, 30);
            this.txtgross.TabIndex = 35;
            // 
            // txtOThours
            // 
            this.txtOThours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOThours.Location = new System.Drawing.Point(276, 375);
            this.txtOThours.Name = "txtOThours";
            this.txtOThours.Size = new System.Drawing.Size(474, 30);
            this.txtOThours.TabIndex = 34;
            this.txtOThours.TextChanged += new System.EventHandler(this.txtOThours_TextChanged);
            // 
            // txtbasep
            // 
            this.txtbasep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasep.Location = new System.Drawing.Point(276, 472);
            this.txtbasep.Name = "txtbasep";
            this.txtbasep.ReadOnly = true;
            this.txtbasep.Size = new System.Drawing.Size(474, 30);
            this.txtbasep.TabIndex = 33;
            // 
            // txtsalid
            // 
            this.txtsalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalid.Location = new System.Drawing.Point(276, 163);
            this.txtsalid.Name = "txtsalid";
            this.txtsalid.Size = new System.Drawing.Size(474, 30);
            this.txtsalid.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Grosspay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "OT Hours";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 53);
            this.label5.TabIndex = 28;
            this.label5.Text = "Salary Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Base Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Salary Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Salary ID";
            // 
            // txtnopay
            // 
            this.txtnopay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnopay.Location = new System.Drawing.Point(276, 424);
            this.txtnopay.Name = "txtnopay";
            this.txtnopay.ReadOnly = true;
            this.txtnopay.Size = new System.Drawing.Size(474, 30);
            this.txtnopay.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "No Pay";
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.LimeGreen;
            this.btncal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(821, 501);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(133, 40);
            this.btncal.TabIndex = 45;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Employee ID";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(276, 571);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(474, 30);
            this.txtempid.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 85);
            this.panel1.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Stencil Std", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(219, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(378, 57);
            this.label10.TabIndex = 24;
            this.label10.Text = "Grifindo Toys";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grifindotoysDataSet1
            // 
            this.grifindotoysDataSet1.DataSetName = "GrifindotoysDataSet1";
            this.grifindotoysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.grifindotoysDataSet1;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // datebegin
            // 
            this.datebegin.Location = new System.Drawing.Point(276, 212);
            this.datebegin.Name = "datebegin";
            this.datebegin.Size = new System.Drawing.Size(474, 22);
            this.datebegin.TabIndex = 49;
            // 
            // dateend
            // 
            this.dateend.Location = new System.Drawing.Point(276, 267);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(474, 22);
            this.dateend.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Salary End Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "No Of Leaves";
            // 
            // txtnoleaves
            // 
            this.txtnoleaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoleaves.Location = new System.Drawing.Point(276, 322);
            this.txtnoleaves.Name = "txtnoleaves";
            this.txtnoleaves.Size = new System.Drawing.Size(474, 30);
            this.txtnoleaves.TabIndex = 53;
            // 
            // grifindotoysDataSet2
            // 
            this.grifindotoysDataSet2.DataSetName = "GrifindotoysDataSet2";
            this.grifindotoysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource1
            // 
            this.salaryBindingSource1.DataMember = "Salary";
            this.salaryBindingSource1.DataSource = this.grifindotoysDataSet2;
            // 
            // salaryTableAdapter1
            // 
            this.salaryTableAdapter1.ClearBeforeFill = true;
            // 
            // salaryTableAdapter2
            // 
            this.salaryTableAdapter2.ClearBeforeFill = true;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1177, 891);
            this.Controls.Add(this.txtnoleaves);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datebegin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtnopay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.saldatagrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtgross);
            this.Controls.Add(this.txtOThours);
            this.Controls.Add(this.txtbasep);
            this.Controls.Add(this.txtsalid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saldatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindotoysDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView saldatagrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtgross;
        private System.Windows.Forms.TextBox txtOThours;
        private System.Windows.Forms.TextBox txtbasep;
        private System.Windows.Forms.TextBox txtsalid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnopay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private GrifindotoysDataSet1 grifindotoysDataSet1;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private GrifindotoysDataSet1TableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.DateTimePicker datebegin;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnoleaves;
        private GrifindotoysDataSet2 grifindotoysDataSet2;
        private System.Windows.Forms.BindingSource salaryBindingSource1;
        private GrifindotoysDataSet2TableAdapters.SalaryTableAdapter salaryTableAdapter1;
        private GrifindotoysDataSet3 grifindotoysDataSet3;
        private System.Windows.Forms.BindingSource salaryBindingSource2;
        private GrifindotoysDataSet3TableAdapters.SalaryTableAdapter salaryTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarybegindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfLeavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oThoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basepayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosspayDataGridViewTextBoxColumn;
    }
}