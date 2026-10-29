namespace HomeForms
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblProject = new System.Windows.Forms.Label();
            this.gbController = new System.Windows.Forms.GroupBox();
            this.rbArduino = new System.Windows.Forms.RadioButton();
            this.rbEsp = new System.Windows.Forms.RadioButton();
            this.rbRaspberry = new System.Windows.Forms.RadioButton();
            this.gbSensors = new System.Windows.Forms.GroupBox();
            this.chkTemp = new System.Windows.Forms.CheckBox();
            this.chkServo = new System.Windows.Forms.CheckBox();
            this.chkLcd = new System.Windows.Forms.CheckBox();
            this.chkKeypad = new System.Windows.Forms.CheckBox();
            this.gbRooms = new System.Windows.Forms.GroupBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.nudRooms = new System.Windows.Forms.NumericUpDown();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbController.SuspendLayout();
            this.gbSensors.SuspendLayout();
            this.gbRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProject.Location = new System.Drawing.Point(20, 15);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(200, 25);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Проект для: [Ім'я]";
            // 
            // gbController
            // 
            this.gbController.Controls.Add(this.rbArduino);
            this.gbController.Controls.Add(this.rbEsp);
            this.gbController.Controls.Add(this.rbRaspberry);
            this.gbController.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbController.Location = new System.Drawing.Point(20, 60);
            this.gbController.Name = "gbController";
            this.gbController.Size = new System.Drawing.Size(290, 170);
            this.gbController.TabIndex = 1;
            this.gbController.TabStop = false;
            this.gbController.Text = "1. Тип контролера";
            // 
            // rbArduino
            // 
            this.rbArduino.AutoSize = true;
            this.rbArduino.Checked = true;
            this.rbArduino.Location = new System.Drawing.Point(20, 40);
            this.rbArduino.Name = "rbArduino";
            this.rbArduino.Size = new System.Drawing.Size(160, 23);
            this.rbArduino.TabIndex = 0;
            this.rbArduino.TabStop = true;
            this.rbArduino.Text = "Arduino Uno - 500 грн";
            this.rbArduino.UseVisualStyleBackColor = true;
            // 
            // rbEsp
            // 
            this.rbEsp.AutoSize = true;
            this.rbEsp.Location = new System.Drawing.Point(20, 80);
            this.rbEsp.Name = "rbEsp";
            this.rbEsp.Size = new System.Drawing.Size(160, 23);
            this.rbEsp.TabIndex = 1;
            this.rbEsp.Text = "ESP8266 - 300 грн";
            this.rbEsp.UseVisualStyleBackColor = true;
            // 
            // rbRaspberry
            // 
            this.rbRaspberry.AutoSize = true;
            this.rbRaspberry.Location = new System.Drawing.Point(20, 120);
            this.rbRaspberry.Name = "rbRaspberry";
            this.rbRaspberry.Size = new System.Drawing.Size(180, 23);
            this.rbRaspberry.TabIndex = 2;
            this.rbRaspberry.Text = "Raspberry Pi - 2500 грн";
            this.rbRaspberry.UseVisualStyleBackColor = true;
            // 
            // gbSensors
            // 
            this.gbSensors.Controls.Add(this.chkTemp);
            this.gbSensors.Controls.Add(this.chkServo);
            this.gbSensors.Controls.Add(this.chkLcd);
            this.gbSensors.Controls.Add(this.chkKeypad);
            this.gbSensors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbSensors.Location = new System.Drawing.Point(330, 60);
            this.gbSensors.Name = "gbSensors";
            this.gbSensors.Size = new System.Drawing.Size(290, 210);
            this.gbSensors.TabIndex = 2;
            this.gbSensors.TabStop = false;
            this.gbSensors.Text = "2. Датчики та модулі";
            // 
            // chkTemp
            // 
            this.chkTemp.AutoSize = true;
            this.chkTemp.Location = new System.Drawing.Point(20, 40);
            this.chkTemp.Name = "chkTemp";
            this.chkTemp.Size = new System.Drawing.Size(240, 23);
            this.chkTemp.TabIndex = 0;
            this.chkTemp.Text = "Датчик температури TMP36 - 150 грн";
            this.chkTemp.UseVisualStyleBackColor = true;
            // 
            // chkServo
            // 
            this.chkServo.AutoSize = true;
            this.chkServo.Location = new System.Drawing.Point(20, 80);
            this.chkServo.Name = "chkServo";
            this.chkServo.Size = new System.Drawing.Size(240, 23);
            this.chkServo.TabIndex = 1;
            this.chkServo.Text = "Сервопривід для дверей - 200 грн";
            this.chkServo.UseVisualStyleBackColor = true;
            // 
            // chkLcd
            // 
            this.chkLcd.AutoSize = true;
            this.chkLcd.Location = new System.Drawing.Point(20, 120);
            this.chkLcd.Name = "chkLcd";
            this.chkLcd.Size = new System.Drawing.Size(160, 23);
            this.chkLcd.TabIndex = 2;
            this.chkLcd.Text = "LCD дисплей - 350 грн";
            this.chkLcd.UseVisualStyleBackColor = true;
            // 
            // chkKeypad
            // 
            this.chkKeypad.AutoSize = true;
            this.chkKeypad.Location = new System.Drawing.Point(20, 160);
            this.chkKeypad.Name = "chkKeypad";
            this.chkKeypad.Size = new System.Drawing.Size(220, 23);
            this.chkKeypad.TabIndex = 3;
            this.chkKeypad.Text = "Матрична клавіатура - 100 грн";
            this.chkKeypad.UseVisualStyleBackColor = true;
            // 
            // gbRooms
            // 
            this.gbRooms.Controls.Add(this.lblRooms);
            this.gbRooms.Controls.Add(this.nudRooms);
            this.gbRooms.Controls.Add(this.lblRoomPrice);
            this.gbRooms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbRooms.Location = new System.Drawing.Point(20, 250);
            this.gbRooms.Name = "gbRooms";
            this.gbRooms.Size = new System.Drawing.Size(290, 110);
            this.gbRooms.TabIndex = 3;
            this.gbRooms.TabStop = false;
            this.gbRooms.Text = "3. Кількість кімнат";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(20, 38);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(120, 19);
            this.lblRooms.TabIndex = 0;
            this.lblRooms.Text = "Кількість кімнат:";
            // 
            // nudRooms
            // 
            this.nudRooms.Location = new System.Drawing.Point(170, 35);
            this.nudRooms.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudRooms.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.ReadOnly = true;
            this.nudRooms.Size = new System.Drawing.Size(70, 25);
            this.nudRooms.TabIndex = 1;
            this.nudRooms.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRoomPrice.Location = new System.Drawing.Point(20, 72);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(200, 19);
            this.lblRoomPrice.TabIndex = 2;
            this.lblRoomPrice.Text = "Базова проводка: 1000 грн/кімн.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(180, 400);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(280, 55);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Розрахувати кошторис";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbRooms);
            this.Controls.Add(this.gbSensors);
            this.Controls.Add(this.gbController);
            this.Controls.Add(this.lblProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home - Конфігуратор";
            this.gbController.ResumeLayout(false);
            this.gbController.PerformLayout();
            this.gbSensors.ResumeLayout(false);
            this.gbSensors.PerformLayout();
            this.gbRooms.ResumeLayout(false);
            this.gbRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.GroupBox gbController;
        private System.Windows.Forms.RadioButton rbArduino;
        private System.Windows.Forms.RadioButton rbEsp;
        private System.Windows.Forms.RadioButton rbRaspberry;
        private System.Windows.Forms.GroupBox gbSensors;
        private System.Windows.Forms.CheckBox chkTemp;
        private System.Windows.Forms.CheckBox chkServo;
        private System.Windows.Forms.CheckBox chkLcd;
        private System.Windows.Forms.CheckBox chkKeypad;
        private System.Windows.Forms.GroupBox gbRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.NumericUpDown nudRooms;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Button btnCalculate;
    }
}