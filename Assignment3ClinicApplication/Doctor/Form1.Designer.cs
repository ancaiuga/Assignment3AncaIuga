namespace Doctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conHourTB = new System.Windows.Forms.TextBox();
            this.idPatientTB = new System.Windows.Forms.TextBox();
            this.detailsTB = new System.Windows.Forms.TextBox();
            this.addCB = new System.Windows.Forms.Button();
            this.viewCTB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultationHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultation Hour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Patient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details :";
            // 
            // conHourTB
            // 
            this.conHourTB.Location = new System.Drawing.Point(132, 50);
            this.conHourTB.Name = "conHourTB";
            this.conHourTB.Size = new System.Drawing.Size(100, 20);
            this.conHourTB.TabIndex = 5;
            // 
            // idPatientTB
            // 
            this.idPatientTB.Location = new System.Drawing.Point(132, 76);
            this.idPatientTB.Name = "idPatientTB";
            this.idPatientTB.Size = new System.Drawing.Size(100, 20);
            this.idPatientTB.TabIndex = 6;
            // 
            // detailsTB
            // 
            this.detailsTB.Location = new System.Drawing.Point(132, 99);
            this.detailsTB.Name = "detailsTB";
            this.detailsTB.Size = new System.Drawing.Size(100, 20);
            this.detailsTB.TabIndex = 7;
            // 
            // addCB
            // 
            this.addCB.Location = new System.Drawing.Point(15, 157);
            this.addCB.Name = "addCB";
            this.addCB.Size = new System.Drawing.Size(75, 23);
            this.addCB.TabIndex = 8;
            this.addCB.Text = "Add";
            this.addCB.UseVisualStyleBackColor = true;
            this.addCB.Click += new System.EventHandler(this.addCB_Click);
            // 
            // viewCTB
            // 
            this.viewCTB.Location = new System.Drawing.Point(132, 157);
            this.viewCTB.Name = "viewCTB";
            this.viewCTB.Size = new System.Drawing.Size(75, 23);
            this.viewCTB.TabIndex = 9;
            this.viewCTB.Text = "View";
            this.viewCTB.UseVisualStyleBackColor = true;
            this.viewCTB.Click += new System.EventHandler(this.viewCTB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consultationDate,
            this.consultationHour,
            this.idPatient,
            this.details});
            this.dataGridView1.Location = new System.Drawing.Point(372, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 182);
            this.dataGridView1.TabIndex = 10;

            // 
            // consultationDate
            // 
            this.consultationDate.DataPropertyName = "consultationDate";
            this.consultationDate.HeaderText = "Consultation Date";
            this.consultationDate.Name = "consultationDate";
            this.consultationDate.ReadOnly = true;
            // 
            // consultationHour
            // 
            this.consultationHour.DataPropertyName = "consultationHour";
            this.consultationHour.HeaderText = "Consultation Hour";
            this.consultationHour.Name = "consultationHour";
            this.consultationHour.ReadOnly = true;
            // 
            // idPatient
            // 
            this.idPatient.DataPropertyName = "idPatient";
            this.idPatient.HeaderText = "Id Patient";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;
            // 
            // details
            // 
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id Doctor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewCTB);
            this.Controls.Add(this.addCB);
            this.Controls.Add(this.detailsTB);
            this.Controls.Add(this.idPatientTB);
            this.Controls.Add(this.conHourTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conHourTB;
        private System.Windows.Forms.TextBox idPatientTB;
        private System.Windows.Forms.TextBox detailsTB;
        private System.Windows.Forms.Button addCB;
        private System.Windows.Forms.Button viewCTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultationHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

