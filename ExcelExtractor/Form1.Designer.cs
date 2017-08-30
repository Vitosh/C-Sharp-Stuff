namespace ExcelExtractor
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblPathFromButton = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtBoxRemoveSheet = new System.Windows.Forms.TextBox();
            this.lblRemoveSheetName = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lvPaths = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPath.Location = new System.Drawing.Point(0, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(63, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path is here";
            // 
            // lblPathFromButton
            // 
            this.lblPathFromButton.AutoSize = true;
            this.lblPathFromButton.Location = new System.Drawing.Point(12, 38);
            this.lblPathFromButton.Name = "lblPathFromButton";
            this.lblPathFromButton.Size = new System.Drawing.Size(86, 13);
            this.lblPathFromButton.TabIndex = 2;
            this.lblPathFromButton.Text = "Here is the label.";
            this.lblPathFromButton.Click += new System.EventHandler(this.lblPathFromButton_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelect.Location = new System.Drawing.Point(593, 123);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(593, 154);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtBoxRemoveSheet
            // 
            this.txtBoxRemoveSheet.Location = new System.Drawing.Point(470, 168);
            this.txtBoxRemoveSheet.Name = "txtBoxRemoveSheet";
            this.txtBoxRemoveSheet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRemoveSheet.TabIndex = 6;
            this.txtBoxRemoveSheet.TextChanged += new System.EventHandler(this.txtBoxRemoveSheet_TextChanged);
            // 
            // lblRemoveSheetName
            // 
            this.lblRemoveSheetName.AutoSize = true;
            this.lblRemoveSheetName.Location = new System.Drawing.Point(323, 170);
            this.lblRemoveSheetName.Name = "lblRemoveSheetName";
            this.lblRemoveSheetName.Size = new System.Drawing.Size(125, 13);
            this.lblRemoveSheetName.TabIndex = 7;
            this.lblRemoveSheetName.Text = "Whatever is in the txtBox";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(12, 190);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(191, 13);
            this.lblReport.TabIndex = 9;
            this.lblReport.Text = "Here is the report from the deleted files.";
            // 
            // lvPaths
            // 
            this.lvPaths.Location = new System.Drawing.Point(15, 64);
            this.lvPaths.Name = "lvPaths";
            this.lvPaths.Size = new System.Drawing.Size(555, 97);
            this.lvPaths.TabIndex = 10;
            this.lvPaths.UseCompatibleStateImageBehavior = false;
            this.lvPaths.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 283);
            this.Controls.Add(this.lvPaths);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblRemoveSheetName);
            this.Controls.Add(this.txtBoxRemoveSheet);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPathFromButton);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "ExcelExtractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblPathFromButton;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtBoxRemoveSheet;
        private System.Windows.Forms.Label lblRemoveSheetName;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ListView lvPaths;
    }
}

