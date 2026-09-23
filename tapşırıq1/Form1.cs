using System;
using System.Collections;
using System.Windows.Forms;

namespace tapşırıq1
{
    public partial class Form1 : Form
    {
        // Foydalanuvchi ma'lumotlarini vaqtincha saqlash uchun ro'yxatlar
        private ArrayList usernames = new ArrayList();
        private ArrayList passwords = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        // Form yuklanganda parollarni yashirish
        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox2 != null) textBox2.UseSystemPasswordChar = true;
            if (textBox4 != null) textBox4.UseSystemPasswordChar = true;
        }

        // SIGN IN (Tizimga kirish) tugmasi - button1
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim(); // Sign In Username
            string pass = textBox2.Text;        // Sign In Password

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Xana boş olmaz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = usernames.IndexOf(user);

            if (index >= 0 && passwords[index] != null && passwords[index].ToString() == pass)
            {
                MessageBox.Show("Sistemə daxil oldunuz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                checkBox1.Checked = false;
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SIGN UP (Ro'yxatdan o'tish) tugmasi - button2
        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox3.Text.Trim(); // Sign Up Username
            string pass = textBox4.Text;        // Sign Up Password

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Xana boş olmaz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usernames.Contains(user))
            {
                MessageBox.Show("Bu istifadəçi adı artıq mövcuddur", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usernames.Add(user);
            passwords.Add(pass);

            MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox3.Clear();
            textBox4.Clear();
            checkBox2.Checked = false;
        }

        // Sign In uchun "Show me password" - checkBox1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                textBox2.UseSystemPasswordChar = !checkBox1.Checked;
            }
        }

        // Sign Up uchun "Show me password" - checkBox2
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4 != null)
            {
                textBox4.UseSystemPasswordChar = !checkBox2.Checked;
            }
        }

        // Eksik olan event metodu (Hatanın çözümü)
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}