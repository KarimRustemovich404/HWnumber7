using System;

namespace HWnumber7.classes
{
    internal class BankAccount
    {
        private decimal balance;
        private double id;
        private string type;

        public BankAccount(decimal balance, double id)
        {
            this.balance = balance;
            this.id = id;
        }

        ///<summary>
        ///Метод для просмотра данных о банковском аккаунте 
        ///</summary>
        public void CheckBankAccount()
        {
            Console.WriteLine($"Сумма на счёте: balance\nНомер: id\nТип счёта: type");
        }

        ///<summary>
        ///Метод для добавления денег на банковский счёт
        ///</summary>
        public void AddToBankAccount(decimal added)
        {
            if (added >= 0)
            {
                balance = balance + added;
            }
            else
            {
                Console.WriteLine("Вы пытаетесь добавить на счёт отрицательную сумму");
            }

        }

        ///<summary>
        ///Метод для снятия денег с банковского счёта
        ///</summary>
        public void RemoveFromBankAccount(decimal removed)
        {
            if (removed > balance)
            {
                Console.WriteLine("На Вашем счёте недостаточно средств для снятия данной суммы");
            }
            else
            {
                balance = balance - removed;
            }
        }

        ///<summary>
        ///Метод для увеличения значения айдишника
        ///</summary>
        public void IncreaseID()
        {
            id++;
        }

        ///<summary>
        ///Метод для перевода денег
        ///</summary>
        public void SendMoney()
        {
            decimal sended = decimal.Parse(Console.ReadLine());
            bool value = decimal.TryParse(Console.ReadLine(), out decimal res);
            if (value)
            {
                if (sended > balance)
                {
                    Console.WriteLine("На вашем счёте недостаточно средств");
                }
                else
                {
                    balance = balance - sended;
                }
            }
            else
            {
                Console.WriteLine("Некорректно введена сумма перевода");
            }
        }
    }
}
