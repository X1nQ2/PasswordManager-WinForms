using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form2 : Form
    {
        private int currentUserId;
        private string currentMasterPassword;
        private Form1 currentParentForm;
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PasswordManagerDB.accdb;";

        public Form2(int userId, string masterPassword, Form1 mainForm)
        {
            InitializeComponent();
            currentUserId = userId;
            currentMasterPassword = masterPassword;
            currentParentForm = mainForm;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Добавить новый пароль";
        }

        // Загрузка категорий из твоего поля Category_id
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Categories";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command)) { adapter.Fill(dt); }
                    }
                    catch (Exception ex) { MessageBox.Show("Ошибка чтения категорий: " + ex.Message); }
                }
            }

            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "Category_id"; // Строго под твое имя поля!
                comboBox1.DisplayMember = "CategoryName";
            }
        }

        // Сохранение строго под твои имена колонок в таблице Passwords
        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string url = textBox2.Text.Trim();
            string login = textBox3.Text.Trim();
            string plainPassword = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(plainPassword))
            {
                MessageBox.Show("Заполните поля Название и Пароль!", "Ошибка");
                return;
            }

            int selectedCategoryId = 1;
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int parsedId))
            {
                selectedCategoryId = parsedId;
            }

            string encryptedPassword = CleanEncrypt(plainPassword, currentMasterPassword);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Запрос учитывает твои точные поля: Category_ID, User_ID
                string query = "INSERT INTO Passwords (Title, URL, Login, EncryptedPassword, Category_ID, User_ID) VALUES (?, ?, ?, ?, ?, ?)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", title);
                    command.Parameters.AddWithValue("?", url);
                    command.Parameters.AddWithValue("?", login);
                    command.Parameters.AddWithValue("?", encryptedPassword);
                    command.Parameters.AddWithValue("?", selectedCategoryId);
                    command.Parameters.AddWithValue("?", currentUserId);
                    try
                    {
                        connection.Open();
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Пароль успешно зашифрован и сохранен в Access!", "Успех");
                            currentParentForm.RefreshData();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка записи в базу: " + ex.Message, "Ошибка");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string CleanEncrypt(string plainText, string password)
        {
            if (string.IsNullOrEmpty(plainText)) return plainText;
            byte[] Salt = Encoding.UTF8.GetBytes("AcademicProjectSalt123!");
            using (var deriveBytes = new Rfc2898DeriveBytes(password, Salt, 10000))
            {
                byte[] key = deriveBytes.GetBytes(32);
                byte[] iv = deriveBytes.GetBytes(16);
                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                            cs.Write(plainBytes, 0, plainBytes.Length);
                            cs.FlushFinalBlock();
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string url = textBox2.Text.Trim();
            string login = textBox3.Text.Trim();
            string plainPassword = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(plainPassword))
            {
                MessageBox.Show("Заполните поля Название и Пароль!", "Ошибка");
                return;
            }

            int selectedCategoryId = 1;
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int parsedId))
            {
                selectedCategoryId = parsedId;
            }

            string encryptedPassword = CleanEncrypt(plainPassword, currentMasterPassword);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Запрос учитывает твои точные поля: Category_ID, User_ID
                string query = "INSERT INTO Passwords (Title, URL, Login, EncryptedPassword, Category_ID, User_ID) VALUES (?, ?, ?, ?, ?, ?)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", title);
                    command.Parameters.AddWithValue("?", url);
                    command.Parameters.AddWithValue("?", login);
                    command.Parameters.AddWithValue("?", encryptedPassword);
                    command.Parameters.AddWithValue("?", selectedCategoryId);
                    command.Parameters.AddWithValue("?", currentUserId);
                    try
                    {
                        connection.Open();
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Пароль успешно зашифрован и сохранен в Access!", "Успех");
                            currentParentForm.RefreshData();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка записи в базу: " + ex.Message, "Ошибка");
                    }
                }
            }   }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
