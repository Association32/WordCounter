namespace WordCounter
{
    partial class Removables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Removables));
            this.groupBoxRemovables = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chckListBoxRemove = new System.Windows.Forms.CheckedListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBoxRemovables.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRemovables
            // 
            this.groupBoxRemovables.Controls.Add(this.btnClearAll);
            this.groupBoxRemovables.Controls.Add(this.btnOk);
            this.groupBoxRemovables.Controls.Add(this.btnCancel);
            this.groupBoxRemovables.Controls.Add(this.chckListBoxRemove);
            this.groupBoxRemovables.Location = new System.Drawing.Point(13, 13);
            this.groupBoxRemovables.Name = "groupBoxRemovables";
            this.groupBoxRemovables.Size = new System.Drawing.Size(260, 258);
            this.groupBoxRemovables.TabIndex = 0;
            this.groupBoxRemovables.TabStop = false;
            this.groupBoxRemovables.Text = "Markr the characters you do not want to count";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(179, 224);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(179, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chckListBoxRemove
            // 
            this.chckListBoxRemove.CheckOnClick = true;
            this.chckListBoxRemove.ColumnWidth = 50;
            this.chckListBoxRemove.FormattingEnabled = true;
            this.chckListBoxRemove.Items.AddRange(new object[] {
            ".",
            ",",
            "\'",
            "?",
            "*",
            "-",
            ":",
            ";",
            "%",
            "\"",
            "#",
            "¤",
            "&",
            "/",
            "(",
            ")",
            "=",
            "+",
            "@",
            "£",
            "$",
            "{",
            "[",
            "]",
            "}",
            "\\",
            "<",
            ">",
            "|",
            "_",
            "½",
            "§",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.chckListBoxRemove.Location = new System.Drawing.Point(6, 19);
            this.chckListBoxRemove.MultiColumn = true;
            this.chckListBoxRemove.Name = "chckListBoxRemove";
            this.chckListBoxRemove.Size = new System.Drawing.Size(162, 229);
            this.chckListBoxRemove.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(179, 166);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Removables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.groupBoxRemovables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Removables";
            this.Text = "Removables";
            this.groupBoxRemovables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRemovables;
        private System.Windows.Forms.CheckedListBox chckListBoxRemove;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearAll;
    }
}