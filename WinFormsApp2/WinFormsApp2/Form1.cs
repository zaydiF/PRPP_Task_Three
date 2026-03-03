using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindApp2  
{
    public class Form1 : Form
    {
        // Задача 1: Калькулятор скидок
        private GroupBox gbDiscount;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnCalculateDiscount;
        private TextBox txtDiscountResult;

        // Задача 2: Проверка пароля
        private GroupBox gbPassword;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCheckPassword;
        private TextBox txtPasswordResult;

        // Задача 3: Конвертер температур
        private GroupBox gbTemperature;
        private Label lblCelsius;
        private TextBox txtCelsius;
        private Label lblFahrenheit;
        private TextBox txtFahrenheit;
        private Button btnToFahrenheit;
        private Button btnToCelsius;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Настройки формы
            this.Text = "Три задачи";
            this.Size = new Size(500, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None; // явно отключаем авто-масштабирование

            //  Задача 1: Калькулятор скидок 
            gbDiscount = new GroupBox();
            gbDiscount.Text = "Задача 1: Калькулятор скидок";
            gbDiscount.Location = new Point(10, 10);
            gbDiscount.Size = new Size(460, 100);

            lblAmount = new Label();
            lblAmount.Text = "Сумма покупки (руб):";
            lblAmount.Location = new Point(10, 25);
            lblAmount.AutoSize = true;

            txtAmount = new TextBox();
            txtAmount.Location = new Point(170, 22);
            txtAmount.Width = 100;

            btnCalculateDiscount = new Button();
            btnCalculateDiscount.Text = "Рассчитать";
            btnCalculateDiscount.Location = new Point(280, 21);
            btnCalculateDiscount.Width = 100;
            btnCalculateDiscount.Height = 25;
            btnCalculateDiscount.Click += BtnCalculateDiscount_Click;

            Label lblResult1 = new Label();
            lblResult1.Text = "Итого:";
            lblResult1.Location = new Point(10, 60);
            lblResult1.AutoSize = true;

            txtDiscountResult = new TextBox();
            txtDiscountResult.Location = new Point(80, 57);
            txtDiscountResult.Width = 100;
            txtDiscountResult.ReadOnly = true;
            txtDiscountResult.BackColor = Color.White;

            gbDiscount.Controls.Add(lblAmount);
            gbDiscount.Controls.Add(txtAmount);
            gbDiscount.Controls.Add(btnCalculateDiscount);
            gbDiscount.Controls.Add(lblResult1);
            gbDiscount.Controls.Add(txtDiscountResult);

            //  Задача 2: Проверка пароля 
            gbPassword = new GroupBox();
            gbPassword.Text = "Задача 2: Проверка надёжности пароля";
            gbPassword.Location = new Point(10, 120);
            gbPassword.Size = new Size(460, 130);

            lblPassword = new Label();
            lblPassword.Text = "Введите пароль:";
            lblPassword.Location = new Point(10, 25);
            lblPassword.AutoSize = true;

            txtPassword = new TextBox();
            txtPassword.Location = new Point(140, 22);
            txtPassword.Width = 150;
            txtPassword.PasswordChar = '*';

            btnCheckPassword = new Button();
            btnCheckPassword.Text = "Проверить";
            btnCheckPassword.Location = new Point(300, 21);
            btnCheckPassword.Width = 100;
            btnCheckPassword.Height = 25;
            btnCheckPassword.Click += BtnCheckPassword_Click;

            Label lblResult2 = new Label();
            lblResult2.Text = "Результат:";
            lblResult2.Location = new Point(10, 60);
            lblResult2.AutoSize = true;

            txtPasswordResult = new TextBox();
            txtPasswordResult.Location = new Point(10, 80);
            txtPasswordResult.Width = 430;
            txtPasswordResult.Height = 30;
            txtPasswordResult.ReadOnly = true;
            txtPasswordResult.BackColor = Color.White;
            txtPasswordResult.Multiline = true;

            gbPassword.Controls.Add(lblPassword);
            gbPassword.Controls.Add(txtPassword);
            gbPassword.Controls.Add(btnCheckPassword);
            gbPassword.Controls.Add(lblResult2);
            gbPassword.Controls.Add(txtPasswordResult);

            //  Задача 3: Конвертер температур 
            gbTemperature = new GroupBox();
            gbTemperature.Text = "Задача 3: Конвертер температур";
            gbTemperature.Location = new Point(10, 260);
            gbTemperature.Size = new Size(460, 150);

            lblCelsius = new Label();
            lblCelsius.Text = "Цельсий (°C):";
            lblCelsius.Location = new Point(10, 25);
            lblCelsius.AutoSize = true;

            txtCelsius = new TextBox();
            txtCelsius.Location = new Point(115, 22);
            txtCelsius.Width = 70;

            lblFahrenheit = new Label();
            lblFahrenheit.Text = "Фаренгейт (°F):";
            lblFahrenheit.Location = new Point(190, 25);
            lblFahrenheit.AutoSize = true;

            txtFahrenheit = new TextBox();
            txtFahrenheit.Location = new Point(310, 22);
            txtFahrenheit.Width = 70;

            btnToFahrenheit = new Button();
            btnToFahrenheit.Text = "→ °F";
            btnToFahrenheit.Location = new Point(80, 55);
            btnToFahrenheit.Width = 70;
            btnToFahrenheit.Height = 25;
            btnToFahrenheit.Click += BtnToFahrenheit_Click;

            btnToCelsius = new Button();
            btnToCelsius.Text = "→ °C";
            btnToCelsius.Location = new Point(240, 55);
            btnToCelsius.Width = 70;
            btnToCelsius.Height = 25;
            btnToCelsius.Click += BtnToCelsius_Click;

            Label lblHint = new Label();
            lblHint.Text = "Введите значение в одном поле и \nнажмите соответствующую кнопку.";
            lblHint.Location = new Point(10, 90);
            lblHint.AutoSize = true;

            gbTemperature.Controls.Add(lblCelsius);
            gbTemperature.Controls.Add(txtCelsius);
            gbTemperature.Controls.Add(lblFahrenheit);
            gbTemperature.Controls.Add(txtFahrenheit);
            gbTemperature.Controls.Add(btnToFahrenheit);
            gbTemperature.Controls.Add(btnToCelsius);
            gbTemperature.Controls.Add(lblHint);

            this.Controls.Add(gbDiscount);
            this.Controls.Add(gbPassword);
            this.Controls.Add(gbTemperature);
        }

        // Задача 1: Обработчик кнопки "Рассчитать"
        private void BtnCalculateDiscount_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount < 0)
                {
                    MessageBox.Show("Введите корректную неотрицательную сумму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal discount = 0;
                if (amount > 5000)
                    discount = 0.10m;      
                else if (amount >= 1000)
                    discount = 0.05m;      

                decimal final = amount * (1 - discount);
                txtDiscountResult.Text = final.ToString("F2") + " руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Задача 2: Обработчик кнопки "Проверить"
        private void BtnCheckPassword_Click(object? sender, EventArgs e)
        {
            string password = txtPassword.Text;

            bool lengthOk = password.Length >= 8;
            bool digitOk = password.Any(char.IsDigit);

            string strength;
            if (lengthOk && digitOk)
                strength = "Надёжный";
            else if (lengthOk || digitOk)
                strength = "Средний";
            else
                strength = "Слабый";

            string result = $"Надёжность: {strength}\n";
            if (!lengthOk)
                result += "• Пароль должен быть не менее 8 символов\n";
            if (!digitOk)
                result += "• Пароль должен содержать хотя бы одну цифру\n";

            txtPasswordResult.Text = result.TrimEnd();
        }

        // Задача 3: Конвертация из Цельсия в Фаренгейты
        private void BtnToFahrenheit_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtCelsius.Text, out double celsius))
                {
                    MessageBox.Show("Введите корректное значение в поле Цельсия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double fahrenheit = celsius * 9 / 5 + 32;
                txtFahrenheit.Text = fahrenheit.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Задача 3: Конвертация из Фаренгейта в Цельсии
        private void BtnToCelsius_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtFahrenheit.Text, out double fahrenheit))
                {
                    MessageBox.Show("Введите корректное значение в поле Фаренгейта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double celsius = (fahrenheit - 32) * 5 / 9;
                txtCelsius.Text = celsius.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
