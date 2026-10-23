namespace PasswordManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordManagerDBDataSet = new PasswordManager.PasswordManagerDBDataSet();
            this.passwordManagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.CategoriesTableAdapter();
            this.passwordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordsTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.PasswordsTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.UsersTableAdapter();
            this.passwordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.passwordsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.passwordsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encryptedPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.удалитьВыбраннуюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьВыбраннуюToolStripMenuItem
            // 
            this.удалитьВыбраннуюToolStripMenuItem.Name = "удалитьВыбраннуюToolStripMenuItem";
            this.удалитьВыбраннуюToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.удалитьВыбраннуюToolStripMenuItem.Text = "Удалить выбранную";
            this.удалитьВыбраннуюToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраннуюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // passwordManagerDBDataSet
            // 
            this.passwordManagerDBDataSet.DataSetName = "PasswordManagerDBDataSet";
            this.passwordManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordManagerDBDataSetBindingSource
            // 
            this.passwordManagerDBDataSetBindingSource.DataSource = this.passwordManagerDBDataSet;
            this.passwordManagerDBDataSetBindingSource.Position = 0;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.passwordManagerDBDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // passwordsBindingSource
            // 
            this.passwordsBindingSource.DataMember = "Passwords";
            this.passwordsBindingSource.DataSource = this.passwordManagerDBDataSet;
            // 
            // passwordsTableAdapter
            // 
            this.passwordsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.passwordManagerDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // passwordsBindingSource1
            // 
            this.passwordsBindingSource1.DataMember = "Passwords";
            this.passwordsBindingSource1.DataSource = this.passwordManagerDBDataSet;
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToOrderColumns = true;
            this.dgvPasswords.AutoGenerateColumns = false;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passwordsIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.encryptedPasswordDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvPasswords.DataSource = this.passwordsBindingSource2;
            this.dgvPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPasswords.Location = new System.Drawing.Point(0, 24);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.Size = new System.Drawing.Size(800, 426);
            this.dgvPasswords.TabIndex = 1;
            // 
            // passwordsBindingSource2
            // 
            this.passwordsBindingSource2.DataMember = "Passwords";
            this.passwordsBindingSource2.DataSource = this.passwordManagerDBDataSet;
            // 
            // passwordsIDDataGridViewTextBoxColumn
            // 
            this.passwordsIDDataGridViewTextBoxColumn.DataPropertyName = "Passwords_ID";
            this.passwordsIDDataGridViewTextBoxColumn.HeaderText = "Passwords_ID";
            this.passwordsIDDataGridViewTextBoxColumn.Name = "passwordsIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // encryptedPasswordDataGridViewTextBoxColumn
            // 
            this.encryptedPasswordDataGridViewTextBoxColumn.DataPropertyName = "EncryptedPassword";
            this.encryptedPasswordDataGridViewTextBoxColumn.HeaderText = "EncryptedPassword";
            this.encryptedPasswordDataGridViewTextBoxColumn.Name = "encryptedPasswordDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPasswords);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.BindingSource passwordManagerDBDataSetBindingSource;
        private PasswordManagerDBDataSet passwordManagerDBDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private PasswordManagerDBDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource passwordsBindingSource;
        private PasswordManagerDBDataSetTableAdapters.PasswordsTableAdapter passwordsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PasswordManagerDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource passwordsBindingSource1;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.BindingSource passwordsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encryptedPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}

