namespace AnswerRecorder
{
    partial class ExamManager
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvWyseExams = new System.Windows.Forms.DataGridView();
            this.Download = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkbSelectAll = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lbExam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyseExams)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WYSE"});
            this.comboBox1.Location = new System.Drawing.Point(74, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dgvWyseExams
            // 
            this.dgvWyseExams.AllowUserToAddRows = false;
            this.dgvWyseExams.AllowUserToDeleteRows = false;
            this.dgvWyseExams.AllowUserToResizeRows = false;
            this.dgvWyseExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyseExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Download,
            this.Name,
            this.Year,
            this.Level,
            this.Type});
            this.dgvWyseExams.Location = new System.Drawing.Point(12, 51);
            this.dgvWyseExams.Name = "dgvWyseExams";
            this.dgvWyseExams.RowHeadersVisible = false;
            this.dgvWyseExams.Size = new System.Drawing.Size(595, 179);
            this.dgvWyseExams.TabIndex = 1;
            // 
            // Download
            // 
            this.Download.HeaderText = "Download";
            this.Download.Name = "Download";
            this.Download.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Download.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // checkbSelectAll
            // 
            this.checkbSelectAll.AutoSize = true;
            this.checkbSelectAll.Location = new System.Drawing.Point(24, 236);
            this.checkbSelectAll.Name = "checkbSelectAll";
            this.checkbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkbSelectAll.TabIndex = 2;
            this.checkbSelectAll.Text = "Select All";
            this.checkbSelectAll.UseVisualStyleBackColor = true;
            this.checkbSelectAll.CheckedChanged += new System.EventHandler(this.checkbSelectAll_CheckedChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(369, 232);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Location = new System.Drawing.Point(21, 15);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(33, 13);
            this.lbExam.TabIndex = 4;
            this.lbExam.Text = "Exam";
            // 
            // ExamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 274);
            this.Controls.Add(this.lbExam);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.checkbSelectAll);
            this.Controls.Add(this.dgvWyseExams);
            this.Controls.Add(this.comboBox1);
            //this.Name = "ExamManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Download Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyseExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvWyseExams;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Download;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.CheckBox checkbSelectAll;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lbExam;
    }
}