using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentOrder_2
{
    internal class PaymentOrder
    {
        private string Person;
        private decimal Price;
        private string BankPerson;
        private int BIK;
        private long INN;
        private string BankRecipient;
        private string CheckRecipient;


        public PaymentOrder(string person, decimal price, string bankperson, int bik, long inn, string bankrecipient, string checkrecipient)
        {
            this.Person = person;
            this.Price = price;
            this.BankPerson = bankperson;
            this.BIK = bik;
            this.INN = inn;
            this.BankRecipient = bankrecipient;
            this.CheckRecipient = checkrecipient;


        }
        public string ShowInfo()
        {
            string[] info = new string[]
            {
                  $"Плательщик: {Person}",
                  $"Cумма: {Price}",
                  $"Банк плательщика: {BankPerson}",
                  $"БИК: {BIK}",
                  $"ИНН: {INN}",
                  $"Банк получателя: {BankRecipient}",
                  $"Счёт получателя: {CheckRecipient}"
            };
           return string.Join(Environment.NewLine, info);
            
        }
    }
}
