
namespace Directory_CourseWork
{
    partial class OrgNameFindFrame
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
            this.FilterLabel = new System.Windows.Forms.Label();
            this.OrgNameLabel = new System.Windows.Forms.Label();
            this.OrgNameButton = new System.Windows.Forms.Button();
            this.OrgNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(35, 48);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(280, 29);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Поиск по организации:";
            this.FilterLabel.Click += new System.EventHandler(this.FilterLabel_Click);
            // 
            // OrgNameLabel
            // 
            this.OrgNameLabel.AutoSize = true;
            this.OrgNameLabel.Location = new System.Drawing.Point(14, 115);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(255, 20);
            this.OrgNameLabel.TabIndex = 2;
            this.OrgNameLabel.Text = "Введите название организации:";
            // 
            // OrgNameButton
            // 
            this.OrgNameButton.Location = new System.Drawing.Point(125, 192);
            this.OrgNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgNameButton.Name = "OrgNameButton";
            this.OrgNameButton.Size = new System.Drawing.Size(103, 50);
            this.OrgNameButton.TabIndex = 6;
            this.OrgNameButton.Text = "Поиск";
            this.OrgNameButton.UseVisualStyleBackColor = true;
            this.OrgNameButton.Click += new System.EventHandler(this.OrgNameButton_Click);
            // 
            // OrgNameTextBox
            // 
            this.OrgNameTextBox.Location = new System.Drawing.Point(14, 140);
            this.OrgNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgNameTextBox.Name = "OrgNameTextBox";
            this.OrgNameTextBox.Size = new System.Drawing.Size(325, 26);
            this.OrgNameTextBox.TabIndex = 7;
            // 
            // OrgNameFindFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 272);
            this.Controls.Add(this.OrgNameTextBox);
            this.Controls.Add(this.OrgNameButton);
            this.Controls.Add(this.OrgNameLabel);
            this.Controls.Add(this.FilterLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrgNameFindFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по организации";
            this.Load += new System.EventHandler(this.OrgNameFindFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label OrgNameLabel;
        private System.Windows.Forms.Button OrgNameButton;
        private System.Windows.Forms.TextBox OrgNameTextBox;
    }
}