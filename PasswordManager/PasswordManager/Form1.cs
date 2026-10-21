using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        private int userId = 1;
        private string masterPassword = "123";
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PasswordManagerDB.accdb;";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Менеджер паролей | Главное окно";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        // Логика чтения ВСЕХ данных без фильтрации по пользователям
        public void RefreshData()
        {
            DataTable dataTable = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Запрос без WHERE вытаскивает абсолютно все 4 строки из Access сразу
                string query = @"SELECT P.Passwords_ID, P.Title, P.URL, P.Login, P.EncryptedPassword, C.CategoryName 
                                 FROM Passwords P 
                                 INNER JOIN Categories C ON P.Category_ID = C.Category_id";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка чтения базы: " + ex.Message, "Ошибка");
                    }
                }
            }

            // Расшифровка поля EncryptedPassword
            foreach (DataRow row in dataTable.Rows)
            {
                if (dataTable.Columns.Contains("EncryptedPassword"))
                {
                    string encrypted = row["EncryptedPassword"].ToString();
                    string decrypted = LocalDecrypt(encrypted, masterPassword);

                    if (decrypted != "[Ошибка расшифровки]")
                    {
                        row["EncryptedPassword"] = decrypted;
                    }
                }
            }

            dgvPasswords.DataSource = dataTable;

            // Настройка отображения колонок в DataGridView
            if (dgvPasswords.Columns.Contains("Passwords_ID")) dgvPasswords.Columns["Passwords_ID"].Visible = false;
            if (dgvPasswords.Columns.Contains("Title")) dgvPasswords.Columns["Title"].HeaderText = "Название";
            if (dgvPasswords.Columns.Contains("URL")) dgvPasswords.Columns["URL"].HeaderText = "Ссылка";
            if (dgvPasswords.Columns.Contains("Login")) dgvPasswords.Columns["Login"].HeaderText = "Логин";
            if (dgvPasswords.Columns.Contains("EncryptedPassword")) dgvPasswords.Columns["EncryptedPassword"].HeaderText = "Пароль";
            if (dgvPasswords.Columns.Contains("CategoryName")) dgvPasswords.Columns["CategoryName"].HeaderText = "Категория";

            dgvPasswords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Логика удаления записи из базы данных
        public bool LocalDeletePassword(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "DELETE FROM Passwords WHERE Passwords_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", id);
                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления: " + ex.Message, "Ошибка");
                        return false;
                    }
                }
            }
        }

        private string LocalDecrypt(string cipherText, string password)
        {
            if (string.IsNullOrEmpty(cipherText)) return cipherText;
            try
            {
                byte[] Salt = Encoding.UTF8.GetBytes("AcademicProjectSalt123!");
                using (var deriveBytes = new Rfc2898DeriveBytes(password, Salt, 10000))
                {
                    byte[] key = deriveBytes.GetBytes(32);
                    byte[] iv = deriveBytes.GetBytes(16);
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = key;
                        aes.IV = iv;
                        using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                        {
                            using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                            using (StreamReader reader = new StreamReader(cs, Encoding.UTF8))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch { return "[Ошибка расшифровки]"; }
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2(userId, masterPassword, this);
            addForm.ShowDialog();
        }

        private void удалитьВыбраннуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;

            // Проверяем, выделена ли строка целиком
            if (dgvPasswords.SelectedRows.Count > 0)
            {
                rowIndex = dgvPasswords.SelectedRows[0].Index; // Теперь здесь строго цифра 0
            }
            // Если строка целиком не выделена, берем строку, где просто кликнули по ячейке
            else if (dgvPasswords.CurrentCell != null)
            {
                rowIndex = dgvPasswords.CurrentCell.RowIndex;
            }

            // Если нашли строку и в ней есть ID для удаления
            if (rowIndex >= 0 && dgvPasswords.Rows[rowIndex].Cells["Passwords_ID"].Value != null)
            {
                int idToDelete = Convert.ToInt32(dgvPasswords.Rows[rowIndex].Cells["Passwords_ID"].Value);

                // Спрашиваем подтверждение перед удалением (для красивой защиты проекта)
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись из базы Access?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (LocalDeletePassword(idToDelete))
                    {
                        MessageBox.Show("Запись успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(); // Перерисовываем таблицу на экране
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись в таблице для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
