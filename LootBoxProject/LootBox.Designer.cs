namespace LootBoxProject
{
    partial class LootBoxClass
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
            this.txtLootBox = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.btnEditBox = new System.Windows.Forms.Button();
            this.btnDeleteBox = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLootBox
            // 
            this.lstLootBox.FormattingEnabled = true;
            this.lstLootBox.Location = new System.Drawing.Point(44, 71);
            this.lstLootBox.Name = "lstLootBox";
            this.lstLootBox.Size = new System.Drawing.Size(195, 225);
            this.lstLootBox.TabIndex = 0;
            this.lstLootBox.SelectedIndexChanged += new System.EventHandler(this.LstLootBox_SelectedIndexChanged);
            // 
            // txtLootBox
            // 
            this.txtLootBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLootBox.Location = new System.Drawing.Point(317, 40);
            this.txtLootBox.Multiline = true;
            this.txtLootBox.Name = "txtLootBox";
            this.txtLootBox.ReadOnly = true;
            this.txtLootBox.Size = new System.Drawing.Size(195, 132);
            this.txtLootBox.TabIndex = 2;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(320, 204);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(192, 135);
            this.txtItem.TabIndex = 3;
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(12, 381);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(134, 23);
            this.btnAddBox.TabIndex = 4;
            this.btnAddBox.Text = "Add Loot Box";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.BtnAddBox_Click);
            // 
            // btnEditBox
            // 
            this.btnEditBox.Location = new System.Drawing.Point(159, 381);
            this.btnEditBox.Name = "btnEditBox";
            this.btnEditBox.Size = new System.Drawing.Size(134, 23);
            this.btnEditBox.TabIndex = 5;
            this.btnEditBox.Text = "Edit Loot Box";
            this.btnEditBox.UseVisualStyleBackColor = true;
            this.btnEditBox.Click += new System.EventHandler(this.BtnEditBox_Click);
            // 
            // btnDeleteBox
            // 
            this.btnDeleteBox.Location = new System.Drawing.Point(308, 381);
            this.btnDeleteBox.Name = "btnDeleteBox";
            this.btnDeleteBox.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteBox.TabIndex = 6;
            this.btnDeleteBox.Text = "Delete Loot Box";
            this.btnDeleteBox.UseVisualStyleBackColor = true;
            this.btnDeleteBox.Click += new System.EventHandler(this.BtnDeleteBox_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lootboxes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lootbox Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lootbox Items";
            // 
            // LootBoxClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteBox);
            this.Controls.Add(this.btnEditBox);
            this.Controls.Add(this.btnAddBox);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtLootBox);
            this.Controls.Add(this.lstLootBox);
            this.Name = "LootBoxClass";
            this.Text = "Lootbox Manager 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLootBox;
        private System.Windows.Forms.TextBox txtLootBox;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Button btnEditBox;
        private System.Windows.Forms.Button btnDeleteBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

