namespace ParsingExcelData
{
    partial class MainWindow
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
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.labelPath = new System.Windows.Forms.Label();
            this.progressBarLoadData = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Load file";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(1, 61);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.Size = new System.Drawing.Size(585, 269);
            this.dataGridViewExcel.TabIndex = 2;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(93, 17);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(47, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "File path";
            // 
            // progressBarLoadData
            // 
            this.progressBarLoadData.Location = new System.Drawing.Point(10, 40);
            this.progressBarLoadData.Name = "progressBarLoadData";
            this.progressBarLoadData.Size = new System.Drawing.Size(564, 15);
            this.progressBarLoadData.TabIndex = 4;
            this.progressBarLoadData.Click += new System.EventHandler(this.progressBarLoadData_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 330);
            this.Controls.Add(this.progressBarLoadData);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.dataGridViewExcel);
            this.Controls.Add(this.buttonLoadFile);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.ProgressBar progressBarLoadData;
    }
}

