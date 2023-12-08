using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PaymentOrder_2
{
    public partial class Form1 : Form
    {
        public int NumberCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberPaymnet(string opertarion)
        {
            this.NumberCount = 0;
            if (opertarion == "+") { this.NumberCount++; }
            else if (opertarion == "-") { this.NumberCount--; }
        }
        private bool ValidateFIO(string Person)
        {           
            string CurrentlyFIO = @"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$";
            if (!Regex.IsMatch(Person, CurrentlyFIO))
            {
                MessageBox.Show("Введите ФИО в формате 'Фамилия Имя Отчество'.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateBIK(string BIK)
        {
            string CurrentlyBIK = "^[0-9]{10}$";
            if (!Regex.IsMatch(BIK.ToString(), CurrentlyBIK))
            {
                MessageBox.Show("БИК должен состоять из 10 цифр.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateINN(string INN)
        {
            string CurrentlyINNUR = "^[0-9]{10}$";
            string CurrentlyINNPRED = "^[0-9]{12}$";
            if (RBUR.Checked)
            {
                if (!Regex.IsMatch(INN.ToString(), CurrentlyINNUR))
                {
                    MessageBox.Show("ИНН должен состоять из 10 цифр.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (RBPRED.Checked)
            {
                if (!Regex.IsMatch(INN.ToString(), CurrentlyINNPRED))
                {
                    MessageBox.Show("ИНН должен состоять из 12 цифр.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (!RBUR.Checked && !RBPRED.Checked)
            {
                MessageBox.Show("Вы не выбрали кем вы являетесь.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
            return true;
        }
        private bool ValidateCheck(string Check)
        {
            string CurrentlyCheck = "^[0-9]{20}$";
            if (!Regex.IsMatch(Check.ToString(), CurrentlyCheck))
            {
                MessageBox.Show("Чек должен состоять из 20 цифр.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void FieldBlock()
        {
            TBPerson.Enabled = false;
            TBPrice.Enabled = false;
            TBCheckRecipient.Enabled = false;
            CBBankPerson.Enabled = false;
            TBBIK.Enabled = false;
            TBINN.Enabled = false;
            CBBankRecipient.Enabled = false;
        }
        private void FieldUnBlock()
        {
            TBPerson.Enabled = true;
            TBPrice.Enabled = true;
            TBCheckRecipient.Enabled = true;
            CBBankPerson.Enabled = true;
            TBBIK.Enabled = true;
            TBINN.Enabled = true;
            CBBankRecipient.Enabled = true;
        }
        private PaymentOrder Parse()
        {
            string Person = TBPerson.Text;
            decimal Price = decimal.Parse(TBPrice.Text);
            string BankPerson = CBBankPerson.SelectedItem.ToString();
            int BIK = int.Parse(TBBIK.Text);
            long INN = long.Parse(TBINN.Text);
            string BankRecipient = CBBankRecipient.SelectedItem.ToString();
            string CheckRecipient = TBCheckRecipient.Text;
            return new PaymentOrder(Person, Price, BankPerson, BIK, INN, BankRecipient, CheckRecipient);
        }
       
        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            bool isFioValid = ValidateFIO(TBPerson.Text);
            bool isBIKValid = ValidateBIK(TBBIK.Text);
            bool isINNValid = ValidateINN(TBINN.Text);
            bool isCheckValid = ValidateCheck(TBCheckRecipient.Text);
            if (isFioValid && isBIKValid && isINNValid && isCheckValid)
            {
                
                ButtonCancel.Visible = false;
                MessageBox.Show("Вы уверены, что хотите отправить платеж.", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                LoadPR.Visible = true;
                PRBAR.Visible = true;
                ButtonCancel.Visible = false;
                ButtonSend.Enabled = false; 
                PRBAR.Value = 0;                
                for (int i = 1; i <= 100; i++)
                {
                    PRBAR.Value = i;
                    await Task.Delay(50); 
                }
                LoadPR.Visible = false;
                PRBAR.Visible = false;
                PRBAR.Value = 0; 
                ButtonSend.Enabled = true;                
                PaymentOrder payment = Parse();
                TBPayment.Text = payment.ShowInfo();
                TBDate.Text = DateTime.Now.ToString();
                FieldBlock();
                NumberPaymnet("+");
                TBNumber.Text = NumberCount.ToString();
                LBSend.Text = "Платежное поручение отправлено!";
                LBSend.Visible = true;
                RBUR.Enabled = false;
                RBPRED.Enabled = false;
                ButtonCancel.Visible = true;
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FieldUnBlock();
            
            LBSend.Text = "Платежное поручение прервано!";
            LBSend.Visible = true;
            RBUR.Enabled = true;
            RBPRED.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            LoadPR.Visible = false;
            PRBAR.Visible = false;
            TBINN.Enabled = false;          
            
            CBBankPerson.SelectedValue = CBBankPerson.SelectedIndex = 0;
            CBBankRecipient.SelectedValue = CBBankRecipient.SelectedIndex = 0;          
        }
        private void RBUR_CheckedChanged(object sender, EventArgs e)
        {           
            TBINN.Enabled = true;
        }
        private void RBPRED_CheckedChanged(object sender, EventArgs e)
        {
            TBINN.Enabled = true;
        }
    }
}
