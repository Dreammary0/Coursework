
namespace Directory_CourseWork
{
    partial class AdressFIndFrame
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
            this.AdressFindButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFindAdress = new System.Windows.Forms.Button();
            this.labelFindAdress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(71, 60);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(246, 29);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Поиск по адресу:";
            // 
            // AdressFindButton
            // 
            this.AdressFindButton.Location = new System.Drawing.Point(28, 280);
            this.AdressFindButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressFindButton.Name = "AdressFindButton";
            this.AdressFindButton.Size = new System.Drawing.Size(103, 44);
            this.AdressFindButton.TabIndex = 6;
            this.AdressFindButton.Text = "Поиск";
            this.AdressFindButton.UseVisualStyleBackColor = true;
            this.AdressFindButton.Click += new System.EventHandler(this.AdressFindButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 26);
            this.textBox1.TabIndex = 7;
            // 
            // buttonFindAdress
            // 
            this.buttonFindAdress.Location = new System.Drawing.Point(197, 280);
            this.buttonFindAdress.Name = "buttonFindAdress";
            this.buttonFindAdress.Size = new System.Drawing.Size(93, 43);
            this.buttonFindAdress.TabIndex = 8;
            this.buttonFindAdress.Text = "Отмена";
            this.buttonFindAdress.UseVisualStyleBackColor = true;
            this.buttonFindAdress.Click += new System.EventHandler(this.buttonFindAdress_Click);
            // 
            // labelFindAdress
            // 
            this.labelFindAdress.AutoSize = true;
            this.labelFindAdress.Location = new System.Drawing.Point(12, 159);
            this.labelFindAdress.Name = "labelFindAdress";
            this.labelFindAdress.Size = new System.Drawing.Size(130, 20);
            this.labelFindAdress.TabIndex = 9;
            this.labelFindAdress.Text = "Введите адрес:";
            // 
            // AdressFIndFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 411);
            this.Controls.Add(this.labelFindAdress);
            this.Controls.Add(this.buttonFindAdress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AdressFindButton);
            this.Controls.Add(this.FilterLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdressFIndFrame";
            this.Text = "Поиск по адресу";
            this.Load += new System.EventHandler(this.AdressFIndFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Button AdressFindButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFindAdress;
        private System.Windows.Forms.Label labelFindAdress;
    }
}