namespace AnswerRecorder
{
    partial class FormApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResponses = new System.Windows.Forms.DataGridView();
            this.QuestionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ofdExamPDF = new System.Windows.Forms.OpenFileDialog();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.btnOption5 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSesssionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSessionAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadExam = new System.Windows.Forms.Button();
            this.btnLoadQuick = new System.Windows.Forms.Button();
            this.lbText1 = new System.Windows.Forms.Label();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbSessionInfo = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.retrieveExamFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponses)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResponses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionNum,
            this.Answer});
            this.dgvResponses.GridColor = System.Drawing.SystemColors.Control;
            this.dgvResponses.Location = new System.Drawing.Point(12, 27);
            this.dgvResponses.MultiSelect = false;
            this.dgvResponses.Name = "dgvResponses";
            this.dgvResponses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResponses.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResponses.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResponses.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResponses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResponses.Size = new System.Drawing.Size(108, 652);
            this.dgvResponses.TabIndex = 5;
            // 
            // QuestionNum
            // 
            this.QuestionNum.HeaderText = "#";
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.Width = 30;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.Width = 60;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(3, 54);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(87, 29);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = false;
            this.pdfViewer.Location = new System.Drawing.Point(133, 27);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.ShowToolbar = false;
            this.pdfViewer.Size = new System.Drawing.Size(861, 560);
            this.pdfViewer.TabIndex = 13;
            this.pdfViewer.Visible = false;
            this.pdfViewer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // btnOption5
            // 
            this.btnOption5.Enabled = false;
            this.btnOption5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption5.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption5.Location = new System.Drawing.Point(706, 3);
            this.btnOption5.Name = "btnOption5";
            this.btnOption5.Size = new System.Drawing.Size(130, 80);
            this.btnOption5.TabIndex = 11;
            this.btnOption5.Text = "E";
            this.btnOption5.UseVisualStyleBackColor = true;
            this.btnOption5.Click += new System.EventHandler(this.btnOption5_Click_1);
            // 
            // btnOption4
            // 
            this.btnOption4.Enabled = false;
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption4.Location = new System.Drawing.Point(570, 3);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(130, 80);
            this.btnOption4.TabIndex = 10;
            this.btnOption4.Text = "D";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click_1);
            // 
            // btnOption3
            // 
            this.btnOption3.Enabled = false;
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption3.Location = new System.Drawing.Point(434, 3);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(130, 80);
            this.btnOption3.TabIndex = 9;
            this.btnOption3.Text = "C";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click_1);
            // 
            // btnOption2
            // 
            this.btnOption2.Enabled = false;
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption2.Location = new System.Drawing.Point(298, 3);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(130, 80);
            this.btnOption2.TabIndex = 8;
            this.btnOption2.Text = "B";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click_1);
            // 
            // btnOption1
            // 
            this.btnOption1.Enabled = false;
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.Color.DimGray;
            this.btnOption1.Location = new System.Drawing.Point(162, 3);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(130, 80);
            this.btnOption1.TabIndex = 7;
            this.btnOption1.Text = "A";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadExamToolStripMenuItem,
            this.saveSesssionToolStripMenuItem,
            this.saveSessionAsToolStripMenuItem,
            this.closeSessionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadExamToolStripMenuItem
            // 
            this.loadExamToolStripMenuItem.Name = "loadExamToolStripMenuItem";
            this.loadExamToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadExamToolStripMenuItem.Text = "Load Exam...";
            this.loadExamToolStripMenuItem.Click += new System.EventHandler(this.loadExamToolStripMenuItem_Click);
            // 
            // saveSesssionToolStripMenuItem
            // 
            this.saveSesssionToolStripMenuItem.Name = "saveSesssionToolStripMenuItem";
            this.saveSesssionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveSesssionToolStripMenuItem.Text = "Save Session";
            this.saveSesssionToolStripMenuItem.Click += new System.EventHandler(this.saveSesssionToolStripMenuItem_Click);
            // 
            // saveSessionAsToolStripMenuItem
            // 
            this.saveSessionAsToolStripMenuItem.Name = "saveSessionAsToolStripMenuItem";
            this.saveSessionAsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveSessionAsToolStripMenuItem.Text = "Save Session As";
            // 
            // closeSessionToolStripMenuItem
            // 
            this.closeSessionToolStripMenuItem.Name = "closeSessionToolStripMenuItem";
            this.closeSessionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.closeSessionToolStripMenuItem.Text = "Close Session";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrieveExamFilesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.submitIssueToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.wikiToolStripMenuItem.Text = "Wiki";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            // 
            // submitIssueToolStripMenuItem
            // 
            this.submitIssueToolStripMenuItem.Name = "submitIssueToolStripMenuItem";
            this.submitIssueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.submitIssueToolStripMenuItem.Text = "Submit Issue";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnLoadExam
            // 
            this.btnLoadExam.Location = new System.Drawing.Point(35, 26);
            this.btnLoadExam.Name = "btnLoadExam";
            this.btnLoadExam.Size = new System.Drawing.Size(271, 71);
            this.btnLoadExam.TabIndex = 16;
            this.btnLoadExam.Text = "Load Exam...";
            this.btnLoadExam.UseVisualStyleBackColor = true;
            this.btnLoadExam.Click += new System.EventHandler(this.btnLoadExam_Click);
            // 
            // btnLoadQuick
            // 
            this.btnLoadQuick.Location = new System.Drawing.Point(35, 159);
            this.btnLoadQuick.Name = "btnLoadQuick";
            this.btnLoadQuick.Size = new System.Drawing.Size(271, 71);
            this.btnLoadQuick.TabIndex = 17;
            this.btnLoadQuick.Text = "Select PDF and Go";
            this.btnLoadQuick.UseVisualStyleBackColor = true;
            this.btnLoadQuick.Click += new System.EventHandler(this.btnLoadQuick_Click);
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.Location = new System.Drawing.Point(156, 122);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(18, 13);
            this.lbText1.TabIndex = 18;
            this.lbText1.Text = "Or";
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.btnLoadExam);
            this.panelStart.Controls.Add(this.lbText1);
            this.panelStart.Controls.Add(this.btnLoadQuick);
            this.panelStart.Location = new System.Drawing.Point(376, 137);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(345, 275);
            this.panelStart.TabIndex = 19;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnCheck);
            this.panelControls.Controls.Add(this.lbSessionInfo);
            this.panelControls.Controls.Add(this.lbTime);
            this.panelControls.Controls.Add(this.btnOption5);
            this.panelControls.Controls.Add(this.btnOption2);
            this.panelControls.Controls.Add(this.btnOption4);
            this.panelControls.Controls.Add(this.btnOption1);
            this.panelControls.Controls.Add(this.btnStartStop);
            this.panelControls.Controls.Add(this.btnOption3);
            this.panelControls.Location = new System.Drawing.Point(133, 593);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(861, 86);
            this.panelControls.TabIndex = 20;
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = global::AnswerRecorder.Properties.Resources.check;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(96, 54);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(31, 29);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbSessionInfo
            // 
            this.lbSessionInfo.AutoSize = true;
            this.lbSessionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSessionInfo.Location = new System.Drawing.Point(4, 3);
            this.lbSessionInfo.Name = "lbSessionInfo";
            this.lbSessionInfo.Size = new System.Drawing.Size(80, 18);
            this.lbSessionInfo.TabIndex = 14;
            this.lbSessionInfo.Text = "Question 1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(5, 23);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(100, 15);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time |  0 : 00 : 00";
            // 
            // retrieveExamFilesToolStripMenuItem
            // 
            this.retrieveExamFilesToolStripMenuItem.Name = "retrieveExamFilesToolStripMenuItem";
            this.retrieveExamFilesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.retrieveExamFilesToolStripMenuItem.Text = "Retrieve Exam Files";
            this.retrieveExamFilesToolStripMenuItem.Click += new System.EventHandler(this.retrieveExamFilesToolStripMenuItem_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 691);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.dgvResponses);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.Text = "AnswerSheet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponses)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResponses;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog ofdExamPDF;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Button btnOption5;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSesssionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSessionAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitIssueToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadExam;
        private System.Windows.Forms.Button btnLoadQuick;
        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lbSessionInfo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolStripMenuItem retrieveExamFilesToolStripMenuItem;
    }
}

