namespace Directory_CourseWork
{
    partial class Error
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
            this.buttonError = new System.Windows.Forms.Button();
            this.Errorlabel1 = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(156, 172);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(88, 37);
            this.buttonError.TabIndex = 0;
            this.buttonError.Text = "OK";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // Errorlabel1
            // 
            this.Errorlabel1.AutoSize = true;
            this.Errorlabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Errorlabel1.Location = new System.Drawing.Point(51, 48);
            this.Errorlabel1.Name = "Errorlabel1";
            this.Errorlabel1.Size = new System.Drawing.Size(322, 43);
            this.Errorlabel1.TabIndex = 1;
            this.Errorlabel1.Text = "Ошибочка, Уважаемый:)";
            this.Errorlabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Errorlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Location = new System.Drawing.Point(104, 113);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(218, 20);
            this.ErrorText.TabIndex = 2;
            this.ErrorText.Text = "Я передумала, ошибки нет.";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 252);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.Errorlabel1);
            this.Controls.Add(this.buttonError);
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Label Errorlabel1;
        private System.Windows.Forms.Label ErrorText;
    }
}