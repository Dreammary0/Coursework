
namespace Directory_CourseWork
{
    partial class AddOrgFrame
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
            this.OrgDataChangesButton = new System.Windows.Forms.Button();
            this.OrgTextBox = new System.Windows.Forms.TextBox();
            this.OrgLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.OrgAddbuttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrgDataChangesButton
            // 
            this.OrgDataChangesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OrgDataChangesButton.Location = new System.Drawing.Point(27, 219);
            this.OrgDataChangesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgDataChangesButton.Name = "OrgDataChangesButton";
            this.OrgDataChangesButton.Size = new System.Drawing.Size(103, 45);
            this.OrgDataChangesButton.TabIndex = 0;
            this.OrgDataChangesButton.Text = "Добавить";
            this.OrgDataChangesButton.UseVisualStyleBackColor = true;
            this.OrgDataChangesButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrgTextBox
            // 
            this.OrgTextBox.Location = new System.Drawing.Point(144, 81);
            this.OrgTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgTextBox.Name = "OrgTextBox";
            this.OrgTextBox.Size = new System.Drawing.Size(223, 26);
            this.OrgTextBox.TabIndex = 1;
            // 
            // OrgLabel
            // 
            this.OrgLabel.AutoSize = true;
            this.OrgLabel.Location = new System.Drawing.Point(14, 84);
            this.OrgLabel.Name = "OrgLabel";
            this.OrgLabel.Size = new System.Drawing.Size(112, 20);
            this.OrgLabel.TabIndex = 2;
            this.OrgLabel.Text = "Организация:";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(22, 30);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(330, 27);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Добавить новую организацию";
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(85, 138);
            this.AdressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(282, 26);
            this.AdressTextBox.TabIndex = 4;
            this.AdressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdressTextBox_KeyPress);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(14, 141);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdressLabel.Size = new System.Drawing.Size(65, 20);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Адрес: ";
            // 
            // OrgAddbuttonNo
            // 
            this.OrgAddbuttonNo.Location = new System.Drawing.Point(210, 219);
            this.OrgAddbuttonNo.Name = "OrgAddbuttonNo";
            this.OrgAddbuttonNo.Size = new System.Drawing.Size(115, 44);
            this.OrgAddbuttonNo.TabIndex = 6;
            this.OrgAddbuttonNo.Text = "Отмена";
            this.OrgAddbuttonNo.UseVisualStyleBackColor = true;
            // 
            // AddOrgFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 295);
            this.Controls.Add(this.OrgAddbuttonNo);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.OrgLabel);
            this.Controls.Add(this.OrgTextBox);
            this.Controls.Add(this.OrgDataChangesButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrgFrame";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.AddOrgFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrgDataChangesButton;
        private System.Windows.Forms.TextBox OrgTextBox;
        private System.Windows.Forms.Label OrgLabel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Button OrgAddbuttonNo;
    }
}