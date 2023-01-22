
namespace Directory_CourseWork
{
    partial class FinderFrame
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
            this.components = new System.ComponentModel.Container();
            this.FindComboBox = new System.Windows.Forms.ComboBox();
            this.FilterDataTypeButton = new System.Windows.Forms.Button();
            this.FinderLabel = new System.Windows.Forms.Label();
            this.Finderbutton = new System.Windows.Forms.Button();
            this.OrgInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrgInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FindComboBox
            // 
            this.FindComboBox.FormattingEnabled = true;
            this.FindComboBox.Items.AddRange(new object[] {
            "Поиск по названию организации",
            "Сбросить поисковик"});
            this.FindComboBox.Location = new System.Drawing.Point(14, 118);
            this.FindComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindComboBox.Name = "FindComboBox";
            this.FindComboBox.Size = new System.Drawing.Size(300, 28);
            this.FindComboBox.TabIndex = 0;
            // 
            // FilterDataTypeButton
            // 
            this.FilterDataTypeButton.Location = new System.Drawing.Point(14, 196);
            this.FilterDataTypeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterDataTypeButton.Name = "FilterDataTypeButton";
            this.FilterDataTypeButton.Size = new System.Drawing.Size(128, 64);
            this.FilterDataTypeButton.TabIndex = 1;
            this.FilterDataTypeButton.Text = "Вот это";
            this.FilterDataTypeButton.UseVisualStyleBackColor = true;
            this.FilterDataTypeButton.Click += new System.EventHandler(this.FilterDataTypeButton_Click);
            // 
            // FinderLabel
            // 
            this.FinderLabel.AutoSize = true;
            this.FinderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinderLabel.Location = new System.Drawing.Point(14, 74);
            this.FinderLabel.Name = "FinderLabel";
            this.FinderLabel.Size = new System.Drawing.Size(118, 22);
            this.FinderLabel.TabIndex = 2;
            this.FinderLabel.Text = "Что поищем:";
            // 
            // Finderbutton
            // 
            this.Finderbutton.Location = new System.Drawing.Point(172, 196);
            this.Finderbutton.Name = "Finderbutton";
            this.Finderbutton.Size = new System.Drawing.Size(142, 64);
            this.Finderbutton.TabIndex = 3;
            this.Finderbutton.Text = "Отмена";
            this.Finderbutton.UseVisualStyleBackColor = true;
            this.Finderbutton.Click += new System.EventHandler(this.Finderbutton_Click);
            // 
            // OrgInfoBindingSource
            // 
            this.OrgInfoBindingSource.DataSource = typeof(Directory_CourseWork.LocalInformation);
            // 
            // FinderFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.Finderbutton);
            this.Controls.Add(this.FinderLabel);
            this.Controls.Add(this.FilterDataTypeButton);
            this.Controls.Add(this.FindComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FinderFrame";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FinderFrame_Frame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrgInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FindComboBox;
        private System.Windows.Forms.Button FilterDataTypeButton;
        private System.Windows.Forms.Label FinderLabel;
        private System.Windows.Forms.BindingSource OrgInfoBindingSource;
        private System.Windows.Forms.Button Finderbutton;
    }
}