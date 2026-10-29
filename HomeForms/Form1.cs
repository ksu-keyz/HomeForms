using HomeForms;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += btnStart_Click;
            FormClosed += Form1_FormClosed;
            this.AcceptButton = btnStart; // Enter = "Почати налаштування"
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть ім'я замовника або назву проекту!",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Передаємо ім'я та посилання на себе через конструктор Form2
            Form2 form2 = new Form2(this, name);
            form2.Show();
            this.Hide();
        }

        // Викликається з Form3 при "Оформити нове замовлення"
        public void ResetForm()
        {
            txtName.Clear();
            txtName.Focus();
        }

        // Закриття "хрестиком" -> повне завершення програми
        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}