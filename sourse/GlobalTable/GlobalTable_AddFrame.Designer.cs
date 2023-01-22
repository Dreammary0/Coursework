
namespace Directory_CourseWork
{
    partial class GlobalTable_AddFrame
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.OrgNameComboBox = new System.Windows.Forms.ComboBox();
            this.OrgNameGlobalLabel = new System.Windows.Forms.Label();
            this.AdressGlobalLabel = new System.Windows.Forms.Label();
            this.AdressComboBox = new System.Windows.Forms.ComboBox();
            this.SaleGlobalLabel = new System.Windows.Forms.Label();
            this.SaleComboTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChangeButton.Location = new System.Drawing.Point(177, 255);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(191, 45);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Добавить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(40, 22);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(230, 28);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Пополнить базу:";
            // 
            // OrgNameComboBox
            // 
            this.OrgNameComboBox.FormattingEnabled = true;
            this.OrgNameComboBox.Location = new System.Drawing.Point(204, 87);
            this.OrgNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgNameComboBox.Name = "OrgNameComboBox";
            this.OrgNameComboBox.Size = new System.Drawing.Size(336, 28);
            this.OrgNameComboBox.TabIndex = 6;
            // 
            // OrgNameGlobalLabel
            // 
            this.OrgNameGlobalLabel.AutoSize = true;
            this.OrgNameGlobalLabel.Location = new System.Drawing.Point(-2, 90);
            this.OrgNameGlobalLabel.Name = "OrgNameGlobalLabel";
            this.OrgNameGlobalLabel.Size = new System.Drawing.Size(187, 20);
            this.OrgNameGlobalLabel.TabIndex = 7;
            this.OrgNameGlobalLabel.Text = "Название организации:";
            // 
            // AdressGlobalLabel
            // 
            this.AdressGlobalLabel.AutoSize = true;
            this.AdressGlobalLabel.Location = new System.Drawing.Point(41, 139);
            this.AdressGlobalLabel.Name = "AdressGlobalLabel";
            this.AdressGlobalLabel.Size = new System.Drawing.Size(73, 20);
            this.AdressGlobalLabel.TabIndex = 10;
            this.AdressGlobalLabel.Text = "Адресс: ";
            // 
            // AdressComboBox
            // 
            this.AdressComboBox.FormattingEnabled = true;
            this.AdressComboBox.Location = new System.Drawing.Point(134, 136);
            this.AdressComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressComboBox.Name = "AdressComboBox";
            this.AdressComboBox.Size = new System.Drawing.Size(406, 28);
            this.AdressComboBox.TabIndex = 11;
            // 
            // SaleGlobalLabel
            // 
            this.SaleGlobalLabel.AutoSize = true;
            this.SaleGlobalLabel.Location = new System.Drawing.Point(41, 190);
            this.SaleGlobalLabel.Name = "SaleGlobalLabel";
            this.SaleGlobalLabel.Size = new System.Drawing.Size(59, 20);
            this.SaleGlobalLabel.TabIndex = 16;
            this.SaleGlobalLabel.Text = "Акция:";
            // 
            // SaleComboTextBox
            // 
            this.SaleComboTextBox.FormattingEnabled = true;
            this.SaleComboTextBox.Location = new System.Drawing.Point(134, 190);
            this.SaleComboTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaleComboTextBox.Name = "SaleComboTextBox";
            this.SaleComboTextBox.Size = new System.Drawing.Size(406, 28);
            this.SaleComboTextBox.TabIndex = 17;
            // 
            // GlobalTable_AddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 328);
            this.Controls.Add(this.SaleComboTextBox);
            this.Controls.Add(this.SaleGlobalLabel);
            this.Controls.Add(this.AdressComboBox);
            this.Controls.Add(this.AdressGlobalLabel);
            this.Controls.Add(this.OrgNameGlobalLabel);
            this.Controls.Add(this.OrgNameComboBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ChangeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalTable_AddFrame";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.GlobalTable_AddFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ComboBox OrgNameComboBox;
        private System.Windows.Forms.Label OrgNameGlobalLabel;
        private System.Windows.Forms.Label AdressGlobalLabel;
        private System.Windows.Forms.ComboBox AdressComboBox;
        private System.Windows.Forms.Label SaleGlobalLabel;
        private System.Windows.Forms.ComboBox SaleComboTextBox;
    }
}