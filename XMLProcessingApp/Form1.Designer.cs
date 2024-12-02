namespace XMLProcessingApp
{
    partial class Form1
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
            txtFilePath = new TextBox();
            btnLoadFile = new Button();
            cmbAttributes = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnTransform = new Button();
            rtbOutput = new RichTextBox();
            btnTransformToHtml = new Button();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(212, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(125, 27);
            txtFilePath.TabIndex = 0;
            txtFilePath.TextChanged += txtFilePath_TextChanged;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(12, 12);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(169, 29);
            btnLoadFile.TabIndex = 1;
            btnLoadFile.Text = "Завантажити файл";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // cmbAttributes
            // 
            cmbAttributes.FormattingEnabled = true;
            cmbAttributes.Location = new Point(212, 58);
            cmbAttributes.Name = "cmbAttributes";
            cmbAttributes.Size = new Size(151, 28);
            cmbAttributes.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(381, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 27);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Ключове слово для пошуку";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Шукати";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnTransform
            // 
            btnTransform.Location = new Point(12, 119);
            btnTransform.Name = "btnTransform";
            btnTransform.Size = new Size(229, 29);
            btnTransform.TabIndex = 5;
            btnTransform.Text = "Трансформувати у HTML";
            btnTransform.UseVisualStyleBackColor = true;
            btnTransform.Click += btnTransform_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(492, 101);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(266, 207);
            rtbOutput.TabIndex = 6;
            rtbOutput.Text = "";
            // 
            // btnTransformToHtml
            // 
            btnTransformToHtml.Location = new Point(12, 378);
            btnTransformToHtml.Name = "btnTransformToHtml";
            btnTransformToHtml.Size = new Size(229, 29);
            btnTransformToHtml.TabIndex = 7;
            btnTransformToHtml.Text = "Трансформувати у HTML";
            btnTransformToHtml.UseVisualStyleBackColor = true;
            btnTransformToHtml.Click += BtnTransformToHtml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransformToHtml);
            Controls.Add(rtbOutput);
            Controls.Add(btnTransform);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbAttributes);
            Controls.Add(btnLoadFile);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "пппп";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnLoadFile;
        private ComboBox cmbAttributes;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnTransform;
        private RichTextBox rtbOutput;
        private Button btnTransformToHtml;
    }
}
