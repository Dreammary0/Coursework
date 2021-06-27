
namespace Directory_CourseWork
{
    partial class GlobalTable_FindFrame
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
            this.FinderComboBox = new System.Windows.Forms.ComboBox();
            this.FilterDataTypeButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.playerInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FinderComboBox
            // 
            this.FinderComboBox.FormattingEnabled = true;
            this.FinderComboBox.Items.AddRange(new object[] {
            "Поиск по названию организации",
            "Поиск по адресу",
            "Сбросить поисковик"});
            this.FinderComboBox.Location = new System.Drawing.Point(14, 118);
            this.FinderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinderComboBox.Name = "FinderComboBox";
            this.FinderComboBox.Size = new System.Drawing.Size(300, 28);
            this.FinderComboBox.TabIndex = 0;
            this.FinderComboBox.SelectedIndexChanged += new System.EventHandler(this.FinderComboBox_SelectedIndexChanged);
            // 
            // FilterDataTypeButton
            // 
            this.FilterDataTypeButton.Location = new System.Drawing.Point(90, 194);
            this.FilterDataTypeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterDataTypeButton.Name = "FilterDataTypeButton";
            this.FilterDataTypeButton.Size = new System.Drawing.Size(147, 58);
            this.FilterDataTypeButton.TabIndex = 1;
            this.FilterDataTypeButton.Text = "Подтвердить";
            this.FilterDataTypeButton.UseVisualStyleBackColor = true;
            this.FilterDataTypeButton.Click += new System.EventHandler(this.FilterDataTypeButton_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.Location = new System.Drawing.Point(14, 74);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(128, 22);
            this.FilterLabel.TabIndex = 2;
            this.FilterLabel.Text = "Чего делаем?";
            // 
            // playerInformationBindingSource
            // 
            this.playerInformationBindingSource.DataSource = typeof(Directory_CourseWork.LocalInformation);
            // 
            // GlobalTable_FindFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterDataTypeButton);
            this.Controls.Add(this.FinderComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GlobalTable_FindFrame";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.GlobalTable_FindFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FinderComboBox;
        private System.Windows.Forms.Button FilterDataTypeButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.BindingSource playerInformationBindingSource;
    }
}