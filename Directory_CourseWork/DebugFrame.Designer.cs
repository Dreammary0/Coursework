
namespace Directory_CourseWork
{
    partial class DebugFrame
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
            this.DebugTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugTextBox.Location = new System.Drawing.Point(0, 0);
            this.DebugTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(514, 674);
            this.DebugTextBox.TabIndex = 0;
            this.DebugTextBox.Text = "";
            this.DebugTextBox.TextChanged += new System.EventHandler(this.DebugTextBox_TextChanged);
            // 
            // DebugFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 674);
            this.Controls.Add(this.DebugTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DebugFrame";
            this.Text = "Отладка";
            this.Load += new System.EventHandler(this.DebugFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DebugTextBox;
    }
}