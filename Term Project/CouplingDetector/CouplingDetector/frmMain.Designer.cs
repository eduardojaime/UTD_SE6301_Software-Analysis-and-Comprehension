namespace CouplingDetector
{
    partial class frmMain
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCoupling = new System.Windows.Forms.CheckBox();
            this.btnScanDocument = new System.Windows.Forms.Button();
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCustomQuery = new System.Windows.Forms.Button();
            this.txtCustomQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSource2srcML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.diaFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.diaFile = new System.Windows.Forms.OpenFileDialog();
            this.tbcMain.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage3);
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(623, 598);
            this.tbcMain.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResults);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btnScanDocument);
            this.tabPage3.Controls.Add(this.btnOpenXML);
            this.tabPage3.Controls.Add(this.txtXMLPath);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnCustomQuery);
            this.tabPage3.Controls.Add(this.txtCustomQuery);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(615, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Code Analyser";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResults.Location = new System.Drawing.Point(3, 151);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(609, 418);
            this.txtResults.TabIndex = 11;
            this.txtResults.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCoupling);
            this.groupBox2.Location = new System.Drawing.Point(372, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metrics";
            // 
            // chkCoupling
            // 
            this.chkCoupling.AutoSize = true;
            this.chkCoupling.Location = new System.Drawing.Point(20, 19);
            this.chkCoupling.Name = "chkCoupling";
            this.chkCoupling.Size = new System.Drawing.Size(115, 17);
            this.chkCoupling.TabIndex = 0;
            this.chkCoupling.Text = "Method Granularity";
            this.chkCoupling.UseVisualStyleBackColor = true;
            // 
            // btnScanDocument
            // 
            this.btnScanDocument.Location = new System.Drawing.Point(11, 122);
            this.btnScanDocument.Name = "btnScanDocument";
            this.btnScanDocument.Size = new System.Drawing.Size(249, 23);
            this.btnScanDocument.TabIndex = 9;
            this.btnScanDocument.Text = "Scan Document";
            this.btnScanDocument.UseVisualStyleBackColor = true;
            this.btnScanDocument.Click += new System.EventHandler(this.btnScanDocument_Click);
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Location = new System.Drawing.Point(266, 29);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXML.TabIndex = 8;
            this.btnOpenXML.Text = "Open XML File";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            this.btnOpenXML.Click += new System.EventHandler(this.btnOpenXML_Click);
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(11, 31);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(249, 20);
            this.txtXMLPath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select the srcML XML file to analyse";
            // 
            // btnCustomQuery
            // 
            this.btnCustomQuery.Location = new System.Drawing.Point(266, 81);
            this.btnCustomQuery.Name = "btnCustomQuery";
            this.btnCustomQuery.Size = new System.Drawing.Size(75, 23);
            this.btnCustomQuery.TabIndex = 5;
            this.btnCustomQuery.Text = "Execute Custom";
            this.btnCustomQuery.UseVisualStyleBackColor = true;
            this.btnCustomQuery.Click += new System.EventHandler(this.btnCustomQuery_Click);
            // 
            // txtCustomQuery
            // 
            this.txtCustomQuery.Location = new System.Drawing.Point(11, 83);
            this.txtCustomQuery.Name = "txtCustomQuery";
            this.txtCustomQuery.Size = new System.Drawing.Size(249, 20);
            this.txtCustomQuery.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter a custom XPATH Query";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSource2srcML);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnOpenFile);
            this.tabPage1.Controls.Add(this.txtFilePath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnOpenFolder);
            this.tabPage1.Controls.Add(this.txtFolderPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source to srcML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSource2srcML
            // 
            this.btnSource2srcML.Location = new System.Drawing.Point(177, 109);
            this.btnSource2srcML.Name = "btnSource2srcML";
            this.btnSource2srcML.Size = new System.Drawing.Size(249, 23);
            this.btnSource2srcML.TabIndex = 7;
            this.btnSource2srcML.Text = "Convert selected folder/file to srcML Format";
            this.btnSource2srcML.UseVisualStyleBackColor = true;
            this.btnSource2srcML.Click += new System.EventHandler(this.btnSource2srcML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFile);
            this.groupBox1.Controls.Add(this.rbFolder);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert by";
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(7, 43);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(73, 17);
            this.rbFile.TabIndex = 1;
            this.rbFile.Text = "Single File";
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.CheckedChanged += new System.EventHandler(this.rbFile_CheckedChanged);
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Location = new System.Drawing.Point(7, 20);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(84, 17);
            this.rbFolder.TabIndex = 0;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Entire Folder";
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.rbFolder_CheckedChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(432, 68);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open Folder";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(177, 70);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(249, 20);
            this.txtFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a single file to convert:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(432, 21);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(177, 23);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(249, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the folder where your source code is located:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "srcML to Source";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open XML File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select the srcML XML file to convert to Source Code";
            // 
            // diaFolder
            // 
            this.diaFolder.ShowNewFolderButton = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 598);
            this.Controls.Add(this.tbcMain);
            this.Name = "frmMain";
            this.Text = "Coupling Detector";
            this.tbcMain.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOpenXML;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCustomQuery;
        private System.Windows.Forms.TextBox txtCustomQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog diaFolder;
        private System.Windows.Forms.OpenFileDialog diaFile;
        private System.Windows.Forms.Button btnSource2srcML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCoupling;
        private System.Windows.Forms.Button btnScanDocument;
        private System.Windows.Forms.RichTextBox txtResults;
    }
}

