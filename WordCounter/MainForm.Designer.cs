namespace WordCounter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditException = new System.Windows.Forms.Button();
            this.btnEditChar = new System.Windows.Forms.Button();
            this.chckboxCapLEtters = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblNrUnique = new System.Windows.Forms.Label();
            this.lblNrWords = new System.Windows.Forms.Label();
            this.lblNrOfUniqueWords = new System.Windows.Forms.Label();
            this.lblnrOfWords = new System.Windows.Forms.Label();
            this.lblResultHeader = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnEditException);
            this.groupBox1.Controls.Add(this.btnEditChar);
            this.groupBox1.Controls.Add(this.chckboxCapLEtters);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnAddText);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.lblInstruction);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnEditException
            // 
            this.btnEditException.Location = new System.Drawing.Point(104, 130);
            this.btnEditException.Name = "btnEditException";
            this.btnEditException.Size = new System.Drawing.Size(102, 23);
            this.btnEditException.TabIndex = 7;
            this.btnEditException.Text = "Edit exceptions";
            this.btnEditException.UseVisualStyleBackColor = true;
            this.btnEditException.Click += new System.EventHandler(this.btnEditException_Click);
            // 
            // btnEditChar
            // 
            this.btnEditChar.Location = new System.Drawing.Point(6, 130);
            this.btnEditChar.Name = "btnEditChar";
            this.btnEditChar.Size = new System.Drawing.Size(92, 23);
            this.btnEditChar.TabIndex = 6;
            this.btnEditChar.Text = "Edit characters";
            this.btnEditChar.UseVisualStyleBackColor = true;
            this.btnEditChar.Click += new System.EventHandler(this.btnEditChar_Click);
            // 
            // chckboxCapLEtters
            // 
            this.chckboxCapLEtters.AutoSize = true;
            this.chckboxCapLEtters.Location = new System.Drawing.Point(6, 159);
            this.chckboxCapLEtters.Name = "chckboxCapLEtters";
            this.chckboxCapLEtters.Size = new System.Drawing.Size(121, 17);
            this.chckboxCapLEtters.TabIndex = 5;
            this.chckboxCapLEtters.Text = "Ignore capital letters";
            this.chckboxCapLEtters.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(247, 157);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(146, 69);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(110, 23);
            this.btnAddText.TabIndex = 3;
            this.btnAddText.Text = "Add text manually";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(87, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(6, 43);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(294, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.BackColor = System.Drawing.SystemColors.Control;
            this.lblInstruction.Location = new System.Drawing.Point(6, 16);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(294, 23);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Write addres to your .txt file or click Browse";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxResult.Controls.Add(this.btnSaveToFile);
            this.groupBoxResult.Controls.Add(this.btnShowList);
            this.groupBoxResult.Controls.Add(this.lblNrUnique);
            this.groupBoxResult.Controls.Add(this.lblNrWords);
            this.groupBoxResult.Controls.Add(this.lblNrOfUniqueWords);
            this.groupBoxResult.Controls.Add(this.lblnrOfWords);
            this.groupBoxResult.Controls.Add(this.lblResultHeader);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 205);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(306, 105);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(87, 76);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 7;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(6, 76);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(75, 23);
            this.btnShowList.TabIndex = 6;
            this.btnShowList.Text = "Show in list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lblNrUnique
            // 
            this.lblNrUnique.AutoSize = true;
            this.lblNrUnique.Location = new System.Drawing.Point(144, 46);
            this.lblNrUnique.Name = "lblNrUnique";
            this.lblNrUnique.Size = new System.Drawing.Size(62, 13);
            this.lblNrUnique.TabIndex = 5;
            this.lblNrUnique.Text = "placeholder";
            // 
            // lblNrWords
            // 
            this.lblNrWords.AutoSize = true;
            this.lblNrWords.Location = new System.Drawing.Point(144, 33);
            this.lblNrWords.Name = "lblNrWords";
            this.lblNrWords.Size = new System.Drawing.Size(62, 13);
            this.lblNrWords.TabIndex = 4;
            this.lblNrWords.Text = "placeholder";
            // 
            // lblNrOfUniqueWords
            // 
            this.lblNrOfUniqueWords.AutoSize = true;
            this.lblNrOfUniqueWords.Location = new System.Drawing.Point(9, 46);
            this.lblNrOfUniqueWords.Name = "lblNrOfUniqueWords";
            this.lblNrOfUniqueWords.Size = new System.Drawing.Size(103, 13);
            this.lblNrOfUniqueWords.TabIndex = 2;
            this.lblNrOfUniqueWords.Text = "Unique words in text";
            // 
            // lblnrOfWords
            // 
            this.lblnrOfWords.AutoSize = true;
            this.lblnrOfWords.Location = new System.Drawing.Point(9, 33);
            this.lblnrOfWords.Name = "lblnrOfWords";
            this.lblnrOfWords.Size = new System.Drawing.Size(69, 13);
            this.lblnrOfWords.TabIndex = 1;
            this.lblnrOfWords.Text = "Words in text";
            // 
            // lblResultHeader
            // 
            this.lblResultHeader.AutoSize = true;
            this.lblResultHeader.Location = new System.Drawing.Point(9, 20);
            this.lblResultHeader.Name = "lblResultHeader";
            this.lblResultHeader.Size = new System.Drawing.Size(45, 13);
            this.lblResultHeader.TabIndex = 0;
            this.lblResultHeader.Text = "Results:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 69);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(212, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Word Counter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label lblResultHeader;
        private System.Windows.Forms.CheckBox chckboxCapLEtters;
        private System.Windows.Forms.Label lblNrOfUniqueWords;
        private System.Windows.Forms.Label lblnrOfWords;
        private System.Windows.Forms.Button btnEditChar;
        private System.Windows.Forms.Button btnEditException;
        private System.Windows.Forms.Label lblNrUnique;
        private System.Windows.Forms.Label lblNrWords;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReset;
    }
}

