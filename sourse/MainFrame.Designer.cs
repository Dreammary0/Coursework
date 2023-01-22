
namespace Directory_CourseWork
{
    partial class MainFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtResult = new System.Windows.Forms.Label();
            this.OrgDatabase = new System.Windows.Forms.TabPage();
            this.PlayersTable_FilterInformation = new System.Windows.Forms.Button();
            this.PlayersTable_RemoveInformation = new System.Windows.Forms.Button();
            this.PlayersTable_AddInformation = new System.Windows.Forms.Button();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.LocalOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablesControl = new System.Windows.Forms.TabControl();
            this.MainDatabase = new System.Windows.Forms.TabPage();
            this.MainTable_SearchButton = new System.Windows.Forms.Button();
            this.MainTable_DeleteInformation = new System.Windows.Forms.Button();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.GlobalOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable_AddInformation = new System.Windows.Forms.Button();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДебагменюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.TablesControl.SuspendLayout();
            this.MainDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(1401, 600);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(55, 20);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "Дебаг";
            // 
            // OrgDatabase
            // 
            this.OrgDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrgDatabase.Controls.Add(this.PlayersTable_FilterInformation);
            this.OrgDatabase.Controls.Add(this.PlayersTable_RemoveInformation);
            this.OrgDatabase.Controls.Add(this.PlayersTable_AddInformation);
            this.OrgDatabase.Controls.Add(this.UsersTable);
            this.OrgDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrgDatabase.Location = new System.Drawing.Point(4, 29);
            this.OrgDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgDatabase.Name = "OrgDatabase";
            this.OrgDatabase.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrgDatabase.Size = new System.Drawing.Size(1430, 548);
            this.OrgDatabase.TabIndex = 1;
            this.OrgDatabase.Text = "Организации";
            this.OrgDatabase.UseVisualStyleBackColor = true;
            // 
            // PlayersTable_FilterInformation
            // 
            this.PlayersTable_FilterInformation.BackColor = System.Drawing.Color.White;
            this.PlayersTable_FilterInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersTable_FilterInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersTable_FilterInformation.Location = new System.Drawing.Point(338, 474);
            this.PlayersTable_FilterInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayersTable_FilterInformation.Name = "PlayersTable_FilterInformation";
            this.PlayersTable_FilterInformation.Size = new System.Drawing.Size(159, 58);
            this.PlayersTable_FilterInformation.TabIndex = 4;
            this.PlayersTable_FilterInformation.Text = "Поиск";
            this.PlayersTable_FilterInformation.UseVisualStyleBackColor = false;
            this.PlayersTable_FilterInformation.Click += new System.EventHandler(this.PlayersTable_FilterInformation_Click);
            // 
            // PlayersTable_RemoveInformation
            // 
            this.PlayersTable_RemoveInformation.BackColor = System.Drawing.Color.White;
            this.PlayersTable_RemoveInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersTable_RemoveInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersTable_RemoveInformation.Location = new System.Drawing.Point(172, 474);
            this.PlayersTable_RemoveInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayersTable_RemoveInformation.Name = "PlayersTable_RemoveInformation";
            this.PlayersTable_RemoveInformation.Size = new System.Drawing.Size(159, 58);
            this.PlayersTable_RemoveInformation.TabIndex = 3;
            this.PlayersTable_RemoveInformation.Text = "Удалить";
            this.PlayersTable_RemoveInformation.UseVisualStyleBackColor = false;
            this.PlayersTable_RemoveInformation.Click += new System.EventHandler(this.PlayersTable_RemoveInformation_Click);
            // 
            // PlayersTable_AddInformation
            // 
            this.PlayersTable_AddInformation.BackColor = System.Drawing.Color.White;
            this.PlayersTable_AddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersTable_AddInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayersTable_AddInformation.Location = new System.Drawing.Point(7, 474);
            this.PlayersTable_AddInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayersTable_AddInformation.Name = "PlayersTable_AddInformation";
            this.PlayersTable_AddInformation.Size = new System.Drawing.Size(159, 58);
            this.PlayersTable_AddInformation.TabIndex = 2;
            this.PlayersTable_AddInformation.Text = "Добавить";
            this.PlayersTable_AddInformation.UseVisualStyleBackColor = false;
            this.PlayersTable_AddInformation.Click += new System.EventHandler(this.PlayersTable_AddInformation_Click);
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.UsersTable.BackgroundColor = System.Drawing.Color.White;
            this.UsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalOrganizationName,
            this.LocalAdress});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.UsersTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersTable.GridColor = System.Drawing.Color.White;
            this.UsersTable.Location = new System.Drawing.Point(3, 4);
            this.UsersTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 24;
            this.UsersTable.Size = new System.Drawing.Size(1424, 462);
            this.UsersTable.TabIndex = 1;
            // 
            // LocalOrganizationName
            // 
            this.LocalOrganizationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocalOrganizationName.HeaderText = "Название организации";
            this.LocalOrganizationName.MinimumWidth = 6;
            this.LocalOrganizationName.Name = "LocalOrganizationName";
            this.LocalOrganizationName.ReadOnly = true;
            this.LocalOrganizationName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LocalAdress
            // 
            this.LocalAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocalAdress.HeaderText = "Адрес";
            this.LocalAdress.MinimumWidth = 6;
            this.LocalAdress.Name = "LocalAdress";
            this.LocalAdress.ReadOnly = true;
            // 
            // TablesControl
            // 
            this.TablesControl.Controls.Add(this.MainDatabase);
            this.TablesControl.Controls.Add(this.OrgDatabase);
            this.TablesControl.Location = new System.Drawing.Point(14, 40);
            this.TablesControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TablesControl.Name = "TablesControl";
            this.TablesControl.SelectedIndex = 0;
            this.TablesControl.Size = new System.Drawing.Size(1438, 581);
            this.TablesControl.TabIndex = 3;
            // 
            // MainDatabase
            // 
            this.MainDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainDatabase.Controls.Add(this.MainTable_SearchButton);
            this.MainDatabase.Controls.Add(this.MainTable_DeleteInformation);
            this.MainDatabase.Controls.Add(this.MainTable);
            this.MainDatabase.Controls.Add(this.MainTable_AddInformation);
            this.MainDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainDatabase.Location = new System.Drawing.Point(4, 29);
            this.MainDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainDatabase.Name = "MainDatabase";
            this.MainDatabase.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainDatabase.Size = new System.Drawing.Size(1430, 548);
            this.MainDatabase.TabIndex = 0;
            this.MainDatabase.Text = "Общий";
            this.MainDatabase.UseVisualStyleBackColor = true;
            // 
            // MainTable_SearchButton
            // 
            this.MainTable_SearchButton.BackColor = System.Drawing.Color.White;
            this.MainTable_SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTable_SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTable_SearchButton.Location = new System.Drawing.Point(338, 474);
            this.MainTable_SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTable_SearchButton.Name = "MainTable_SearchButton";
            this.MainTable_SearchButton.Size = new System.Drawing.Size(159, 58);
            this.MainTable_SearchButton.TabIndex = 3;
            this.MainTable_SearchButton.Text = "Поиск";
            this.MainTable_SearchButton.UseVisualStyleBackColor = false;
            this.MainTable_SearchButton.Click += new System.EventHandler(this.MainTable_SearchButton_Click);
            // 
            // MainTable_DeleteInformation
            // 
            this.MainTable_DeleteInformation.BackColor = System.Drawing.Color.White;
            this.MainTable_DeleteInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTable_DeleteInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTable_DeleteInformation.Location = new System.Drawing.Point(172, 474);
            this.MainTable_DeleteInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTable_DeleteInformation.Name = "MainTable_DeleteInformation";
            this.MainTable_DeleteInformation.Size = new System.Drawing.Size(159, 58);
            this.MainTable_DeleteInformation.TabIndex = 2;
            this.MainTable_DeleteInformation.Text = "Удалить";
            this.MainTable_DeleteInformation.UseVisualStyleBackColor = false;
            this.MainTable_DeleteInformation.Click += new System.EventHandler(this.MainTable_DeleteInformation_Click);
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.NullValue = "--";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MainTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.MainTable.BackgroundColor = System.Drawing.Color.White;
            this.MainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GlobalOrganizationName,
            this.GlobalAdress,
            this.GlobalSale});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainTable.DefaultCellStyle = dataGridViewCellStyle15;
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTable.Location = new System.Drawing.Point(3, 4);
            this.MainTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.MainTable.RowHeadersVisible = false;
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 24;
            this.MainTable.Size = new System.Drawing.Size(1424, 462);
            this.MainTable.TabIndex = 0;
            this.MainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellContentClick);
            // 
            // GlobalOrganizationName
            // 
            this.GlobalOrganizationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GlobalOrganizationName.HeaderText = "Название организации";
            this.GlobalOrganizationName.MinimumWidth = 8;
            this.GlobalOrganizationName.Name = "GlobalOrganizationName";
            this.GlobalOrganizationName.ReadOnly = true;
            // 
            // GlobalAdress
            // 
            this.GlobalAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GlobalAdress.HeaderText = "Адрес";
            this.GlobalAdress.MinimumWidth = 8;
            this.GlobalAdress.Name = "GlobalAdress";
            this.GlobalAdress.ReadOnly = true;
            // 
            // GlobalSale
            // 
            this.GlobalSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GlobalSale.HeaderText = "Название акции";
            this.GlobalSale.MinimumWidth = 8;
            this.GlobalSale.Name = "GlobalSale";
            this.GlobalSale.ReadOnly = true;
            // 
            // MainTable_AddInformation
            // 
            this.MainTable_AddInformation.BackColor = System.Drawing.Color.White;
            this.MainTable_AddInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainTable_AddInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainTable_AddInformation.Location = new System.Drawing.Point(7, 474);
            this.MainTable_AddInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTable_AddInformation.Name = "MainTable_AddInformation";
            this.MainTable_AddInformation.Size = new System.Drawing.Size(159, 58);
            this.MainTable_AddInformation.TabIndex = 1;
            this.MainTable_AddInformation.Text = "Добавить";
            this.MainTable_AddInformation.UseVisualStyleBackColor = false;
            this.MainTable_AddInformation.Click += new System.EventHandler(this.AddInformation_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // открытьДебагменюToolStripMenuItem
            // 
            this.открытьДебагменюToolStripMenuItem.Name = "открытьДебагменюToolStripMenuItem";
            this.открытьДебагменюToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.открытьДебагменюToolStripMenuItem.Text = "Открыть дебаг-меню";
            this.открытьДебагменюToolStripMenuItem.Click += new System.EventHandler(this.открытьДебагменюToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.открытьДебагменюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1465, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // OrganizationName
            // 
            this.OrganizationName.HeaderText = "Название организации";
            this.OrganizationName.MinimumWidth = 8;
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.ReadOnly = true;
            this.OrganizationName.Width = 150;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Адрес";
            this.Adress.MinimumWidth = 8;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 150;
            // 
            // Sale
            // 
            this.Sale.HeaderText = "Акция";
            this.Sale.MinimumWidth = 8;
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            this.Sale.Width = 150;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 634);
            this.Controls.Add(this.TablesControl);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrame";
            this.Text = "Справочник \"MYMAP\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.OrgDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.TablesControl.ResumeLayout(false);
            this.MainDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.TabPage OrgDatabase;
        private System.Windows.Forms.Button PlayersTable_FilterInformation;
        private System.Windows.Forms.Button PlayersTable_RemoveInformation;
        private System.Windows.Forms.Button PlayersTable_AddInformation;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.TabControl TablesControl;
        private System.Windows.Forms.TabPage MainDatabase;
        private System.Windows.Forms.Button MainTable_SearchButton;
        private System.Windows.Forms.Button MainTable_DeleteInformation;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Button MainTable_AddInformation;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДебагменюToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlobalOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlobalAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlobalSale;
    }
}

