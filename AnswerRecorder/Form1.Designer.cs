namespace AnswerRecorder
{
    partial class formWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption5 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResponses = new System.Windows.Forms.DataGridView();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.ofdPreviousResponses = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption1.Location = new System.Drawing.Point(245, 74);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(130, 130);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "A";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.BtnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption2.Location = new System.Drawing.Point(381, 74);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(130, 130);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "B";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.BtnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption3.Location = new System.Drawing.Point(517, 74);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(130, 130);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "C";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.BtnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption4.Location = new System.Drawing.Point(653, 74);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(130, 130);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "D";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.BtnOption4_Click);
            // 
            // btnOption5
            // 
            this.btnOption5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption5.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption5.Location = new System.Drawing.Point(789, 74);
            this.btnOption5.Name = "btnOption5";
            this.btnOption5.Size = new System.Drawing.Size(130, 130);
            this.btnOption5.TabIndex = 4;
            this.btnOption5.Text = "E";
            this.btnOption5.UseVisualStyleBackColor = true;
            this.btnOption5.Click += new System.EventHandler(this.BtnOption5_Click);
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            // 
            // dgvResponses
            // 
            this.dgvResponses.AllowUserToAddRows = false;
            this.dgvResponses.AllowUserToDeleteRows = false;
            this.dgvResponses.AllowUserToResizeColumns = false;
            this.dgvResponses.AllowUserToResizeRows = false;
            this.dgvResponses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResponses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResponses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResponses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Answer});
            this.dgvResponses.GridColor = System.Drawing.SystemColors.Control;
            this.dgvResponses.Location = new System.Drawing.Point(12, 12);
            this.dgvResponses.MultiSelect = false;
            this.dgvResponses.Name = "dgvResponses";
            this.dgvResponses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResponses.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResponses.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResponses.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResponses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResponses.Size = new System.Drawing.Size(202, 297);
            this.dgvResponses.TabIndex = 5;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(239, 21);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(166, 33);
            this.lbQuestion.TabIndex = 6;
            this.lbQuestion.Text = "Question 1";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(240, 246);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(178, 25);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "Time |  0 : 00 : 00";
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(732, 240);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(106, 42);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Location = new System.Drawing.Point(620, 240);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(106, 42);
            this.btnLoadSave.TabIndex = 9;
            this.btnLoadSave.Text = "Load";
            this.btnLoadSave.UseVisualStyleBackColor = true;
            this.btnLoadSave.Click += new System.EventHandler(this.btnLoadSave_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(844, 21);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // formWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 321);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.dgvResponses);
            this.Controls.Add(this.btnOption5);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formWindow";
            this.Text = "AnswerRecorder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridView dgvResponses;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnLoadSave;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.OpenFileDialog ofdPreviousResponses;
    }
}

