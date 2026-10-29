using HomeForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace HomeForms
{
    public partial class Form3 : Form
    {
        private readonly Form1 _startForm;
        private readonly Form2 _configForm;

        // true -> закриття форми НЕ завершує програму
        private bool _suppressExit = false;

        public Form3(Form1 startForm, Form2 configForm, string customerName,
                     List<string> items, int total)
        {
            InitializeComponent();
            btnNew.Click += btnNew_Click;
            btnExit.Click += btnExit_Click;
            FormClosed += Form3_FormClosed;
            _startForm = startForm;
            _configForm = configForm;

            lblTitle.Text = "Фінальний кошторис проекту: " + customerName;
            txtList.Text = string.Join(Environment.NewLine, items);
            lblTotal.Text = "Разом до оплати: " + total + " грн";
        }

        private void btnNew_Click(object? sender, EventArgs e)
        {
            // Закриваємо приховану Form2 і поточну Form3 без виходу з програми
            _configForm.SuppressExit = true;
            _configForm.Close();

            _suppressExit = true;
            _startForm.ResetForm();   // очищаємо поля
            _startForm.Show();        // показуємо першу форму
            this.Close();
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!_suppressExit)
                Application.Exit();
        }
    }
}