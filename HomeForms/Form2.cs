using HomeForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeForms
{

    public partial class Form2 : Form
    {
        private const int RoomPrice = 1000;

        private readonly Form1 _startForm;
        private readonly string _customerName;

        // true -> закриття форми НЕ завершує програму (коли Form3 закриває її програмно)
        internal bool SuppressExit = false;

        public Form2(Form1 startForm, string customerName)
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
            FormClosed += Form2_FormClosed;
            _startForm = startForm;
            _customerName = customerName;
            lblProject.Text = "Проект для: " + _customerName;
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            int total = 0;
            List<string> items = new List<string>();

            // Блок 1: контролер (один з трьох)
            if (rbArduino.Checked)
            {
                total += 500;
                items.Add("Контролер Arduino Uno - 500 грн");
            }
            else if (rbEsp.Checked)
            {
                total += 300;
                items.Add("Контролер ESP8266 - 300 грн");
            }
            else if (rbRaspberry.Checked)
            {
                total += 2500;
                items.Add("Контролер Raspberry Pi - 2500 грн");
            }

            // Блок 2: датчики та модулі (кілька)
            if (chkTemp.Checked)
            {
                total += 150;
                items.Add("Датчик температури TMP36 - 150 грн");
            }
            if (chkServo.Checked)
            {
                total += 200;
                items.Add("Сервопривід для дверей - 200 грн");
            }
            if (chkLcd.Checked)
            {
                total += 350;
                items.Add("LCD дисплей - 350 грн");
            }
            if (chkKeypad.Checked)
            {
                total += 100;
                items.Add("Матрична клавіатура - 100 грн");
            }

            // Блок 3: кімнати
            int rooms = (int)nudRooms.Value;
            int wiring = rooms * RoomPrice;
            total += wiring;
            items.Add("Базова проводка: " + rooms + " кімн. x " + RoomPrice + " грн = " + wiring + " грн");

            Form3 form3 = new Form3(_startForm, this, _customerName, items, total);
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!SuppressExit)
                Application.Exit();
        }
    }
}