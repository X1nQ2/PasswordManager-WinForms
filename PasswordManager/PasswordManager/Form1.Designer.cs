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
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.passwordManagerDBDataSet = new PasswordManager.PasswordManagerDBDataSet();
            this.passwordManagerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.CategoriesTableAdapter();
            this.passwordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passwordsTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.PasswordsTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PasswordManager.PasswordManagerDBDataSetTableAdapters.UsersTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
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
            // dgvPasswords
            // 
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Location = new System.Drawing.Point(0, 27);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.Size = new System.Drawing.Size(800, 425);
            this.dgvPasswords.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordManagerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPasswords;
    }
}

