using HWnumber7.classes;

namespace HWnumber7
{
    internal class Lab_UPR_8_1
    {
        enum TypesOfAccount
        {
            Saving,
            Deposit,
            Credit
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(balance: 100, id: 1);
        }
    }
}
