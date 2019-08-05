namespace LootBoxProject
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
            this.lstLootBox = new System.Windows.Forms.ListBox();
            this.LstItem = new System.Windows.Forms.ListBox();
            this.txtLootBox = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.btnEditBox = new System.Windows.Forms.Button();
            this.btnDeleteBox = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLootBox
            // 
            this.lstLootBox.FormattingEnabled = true;
            this.lstLootBox.Location = new System.Drawing.Point(24, 94);
            this.lstLootBox.Name = "lstLootBox";
            this.lstLootBox.Size = new System.Drawing.Size(195, 121);
            this.lstLootBox.TabIndex = 0;
            // 
            // LstItem
            // 
            this.LstItem.FormattingEnabled = true;
            this.LstItem.Location = new System.Drawing.Point(225, 94);
            this.LstItem.Name = "LstItem";
            this.LstItem.Size = new System.Drawing.Size(192, 121);
            this.LstItem.TabIndex = 1;
            // 
            // txtLootBox
            // 
            this.txtLootBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLootBox.Location = new System.Drawing.Point(24, 221);
            this.txtLootBox.Multiline = true;
            this.txtLootBox.Name = "txtLootBox";
            this.txtLootBox.ReadOnly = true;
            this.txtLootBox.Size = new System.Drawing.Size(195, 164);
            this.txtLootBox.TabIndex = 2;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(225, 221);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(192, 164);
            this.txtItem.TabIndex = 3;
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(448, 192);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(134, 23);
            this.btnAddBox.TabIndex = 4;
            this.btnAddBox.Text = "Add Loot Box";
            this.btnAddBox.UseVisualStyleBackColor = true;
            // 
            // btnEditBox
            // 
            this.btnEditBox.Location = new System.Drawing.Point(448, 221);
            this.btnEditBox.Name = "btnEditBox";
            this.btnEditBox.Size = new System.Drawing.Size(134, 23);
            this.btnEditBox.TabIndex = 5;
            this.btnEditBox.Text = "Edit Loot Box";
            this.btnEditBox.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBox
            // 
            this.btnDeleteBox.Location = new System.Drawing.Point(448, 250);
            this.btnDeleteBox.Name = "btnDeleteBox";
            this.btnDeleteBox.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteBox.TabIndex = 6;
            this.btnDeleteBox.Text = "Delete Loot Box";
            this.btnDeleteBox.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 444);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteBox);
            this.Controls.Add(this.btnEditBox);
            this.Controls.Add(this.btnAddBox);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtLootBox);
            this.Controls.Add(this.LstItem);
            this.Controls.Add(this.lstLootBox);
            this.Name = "Form1";
            this.Text = "LootBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLootBox;
        private System.Windows.Forms.ListBox LstItem;
        private System.Windows.Forms.TextBox txtLootBox;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Button btnEditBox;
        private System.Windows.Forms.Button btnDeleteBox;
        private System.Windows.Forms.Button btnClose;
    }
}

