using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentOrder
{
    internal class PaymentOrder
    {
        private string Person;
        private double Price;
        private string BankPerson;
        private int BIK;
        private int INN;
        private string BankRecipient;
        private long CheckRecipient;
        

        public PaymentOrder(string person, double price, string bankperson,int bik,int inn,string bankrecipient, long checkrecipient)
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
            string str;
            return str = $"Плательщик: {Person}\nCумма: {Price}\nБанк плательщика: {BankPerson}\nБик: {BIK}\nИНН: {INN}\nБанк получателя: {BankRecipient}\nСчёт получателя: {CheckRecipient}";
        }
        
    }
}
