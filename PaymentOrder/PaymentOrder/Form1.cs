using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentOrder
{
    public partial class Form1 : Form
    {
        private int NumberCount = 0;
        private bool CurrentlyFIO = true;

        private bool CurrentlyBIKUR = true;
        private bool CurrentlyINN = true;
        private bool CurrentlyCheak = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void RegFIOBIKINNCheak(string FIO, int BIK, int INN, long Cheak)
        {

            string CurrentlyFIO = @"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$";
            if (!Regex.IsMatch(FIO, CurrentlyFIO))
            {
                this.CurrentlyFIO = false;
                MessageBox.Show("Введите ФИО в формате 'Фамилия Имя Отчество'.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string CurrentlyBIK = "^[0-9]{9}$";
            if (!Regex.IsMatch(Convert.ToString(BIK), CurrentlyBIK))
            {
                this.CurrentlyBIKUR = false;
                MessageBox.Show("БИК должен состоять из 9 цифр.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string CurrentlyINN = "^[0-9]{10}$";
            if (!Regex.IsMatch(Convert.ToString(INN), CurrentlyINN))
            {
                this.CurrentlyINN = false;
                MessageBox.Show("ИНН должен состоять из 10 цифр.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string CurrentlyCheak = "^[0-9]{10}$";
            if (!Regex.IsMatch(Convert.ToString(Cheak), CurrentlyCheak))
            {
                this.CurrentlyCheak = false;
                MessageBox.Show("Счёт получателя должен состоять из 10 цифр.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void Block()
        {
            TextBoxPerson.Enabled = false;
            TextBoxPrice.Enabled = false;
            ComboBoxBankPerson.Enabled = false;
            TextBoxBIK.Enabled = false;
            TextBoxINN.Enabled = false;
            ComboBoxBankRecipient.Enabled = false;
            TextBoxCheckRecipient.Enabled = false;
        }
        private void Unblock()
        {
            TextBoxPerson.Enabled = true;
            TextBoxPrice.Enabled = true;
            ComboBoxBankPerson.Enabled = true;
            TextBoxBIK.Enabled = true;
            TextBoxINN.Enabled = true;
            ComboBoxBankRecipient.Enabled = true;
            TextBoxCheckRecipient.Enabled = true;
        }
        private void Delete()
        {
            TextBoxPerson.Text = " ";
            TextBoxPrice.Text = " ";
            ComboBoxBankPerson.Text = " ";
            TextBoxBIK.Text = " ";
            TextBoxINN.Text = " ";
            ComboBoxBankRecipient.Text = " ";
            TextBoxCheckRecipient.Text = " ";
        }

        private PaymentOrder ParsePerem()
        {
            string person = TextBoxPerson.Text;
            double price = Convert.ToDouble(TextBoxPrice.Text);
            string bankPerson = ComboBoxBankPerson.SelectedItem.ToString();
            int bik = Convert.ToInt32(TextBoxBIK.Text);
            int inn = Convert.ToInt32(TextBoxINN.Text);
            string bankRecipient = ComboBoxBankRecipient.SelectedItem.ToString();
            long checkrecipient = Convert.ToInt64(TextBoxCheckRecipient.Text);

            return new PaymentOrder(person, price, bankPerson, bik, inn, bankRecipient, checkrecipient);
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {

            string FIO = TextBoxPerson.Text;
            int BIK = Convert.ToInt32(TextBoxBIK.Text);
            int INN = Convert.ToInt32(TextBoxINN.Text);
            long Cheak = Convert.ToInt64(TextBoxCheckRecipient.Text);
            RegFIOBIKINNCheak(FIO, BIK, INN, Cheak);
           
            
               
                
                    PaymentOrder payment = ParsePerem();
                    TextPayment.Text = payment.ShowInfo();
                    Block();
                  
                    TextBoxNumberPayment.Text = NumberCount.ToString();
                    TextSuccessfullyPayment.Visible = true;
                    TextSuccessfullyPayment.Text = "Платежное поручение отправлено на проверку";

                
                
                if(TextPerson.Enabled = true)
            {
 TextPayment.Text = " ";
                    this.NumberCount ++;
                    TextBoxNumberPayment.Text = NumberCount.ToString();
                
            }
                   
            
















        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {


            this.NumberCount = 0;
            TextBoxNumberPayment.Text = NumberCount.ToString();


            Unblock();
            TextSuccessfullyPayment.Visible = true;
            TextSuccessfullyPayment.Text = "Отправка платежного поручения прервана!";

        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxDate.Text = DateTime.Now.ToString();
        }

        private void TextBoxNumberPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            TextPayment.Text = " ";
            Delete();
            Unblock();
            this.NumberCount = 0;
            TextBoxNumberPayment.Text = NumberCount.ToString();
        }
    }
}
