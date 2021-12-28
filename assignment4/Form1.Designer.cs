
namespace RandomNumberFileWriter
{
    partial class SaveFileDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dialogLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.theNumber = new System.Windows.Forms.TextBox();
            this.totalNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numbersList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 273);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dialogLabel);
            this.tabPage1.Controls.Add(this.cancelBtn);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.numInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Writing";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.writingFocused);
            // 
            // dialogLabel
            // 
            this.dialogLabel.AutoSize = true;
            this.dialogLabel.Location = new System.Drawing.Point(26, 70);
            this.dialogLabel.Name = "dialogLabel";
            this.dialogLabel.Size = new System.Drawing.Size(370, 15);
            this.dialogLabel.TabIndex = 7;
            this.dialogLabel.Text = "How many Random numbers would you like to save to a file? (1-100)";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(222, 139);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(121, 139);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save to File";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(121, 101);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(176, 23);
            this.numInput.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resetBtn);
            this.tabPage2.Controls.Add(this.readBtn);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numbersList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reading";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.readingFocused);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(159, 19);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(29, 19);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(122, 23);
            this.readBtn.TabIndex = 5;
            this.readBtn.Text = "Read from File";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.theNumber);
            this.groupBox1.Controls.Add(this.totalNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(17, 46);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(212, 23);
            this.filePath.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Path";
            // 
            // theNumber
            // 
            this.theNumber.Location = new System.Drawing.Point(17, 150);
            this.theNumber.Name = "theNumber";
            this.theNumber.ReadOnly = true;
            this.theNumber.Size = new System.Drawing.Size(212, 23);
            this.theNumber.TabIndex = 7;
            // 
            // totalNumber
            // 
            this.totalNumber.Location = new System.Drawing.Point(17, 98);
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.ReadOnly = true;
            this.totalNumber.Size = new System.Drawing.Size(212, 23);
            this.totalNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "The Number of Random Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Total of the Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numbers read from the file";
            // 
            // numbersList
            // 
            this.numbersList.FormattingEnabled = true;
            this.numbersList.ItemHeight = 15;
            this.numbersList.Location = new System.Drawing.Point(260, 37);
            this.numbersList.Name = "numbersList";
            this.numbersList.Size = new System.Drawing.Size(152, 199);
            this.numbersList.TabIndex = 0;
            // 
            // SaveFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 274);
            this.Controls.Add(this.tabControl1);
            this.Name = "SaveFileDialog";
            this.Text = "Write and Read Random Numbers";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label dialogLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox numbersList;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox theNumber;
        private System.Windows.Forms.TextBox totalNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
    }
}

