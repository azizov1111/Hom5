// public class BankAccount
// {
//     private readonly int accountId;
//     private decimal balance;
//     public string OwnerName { get; set; }
//     private bool isFrozen;

//     public BankAccount(int accountId, string ownerName, decimal balance)
//     {
//         this.accountId = accountId;
//         OwnerName = ownerName;
//         this.balance = balance;
//         isFrozen = false;
//     }

//     public int GetAccountId()
//     {
//         return accountId;
//     }

//     public decimal GetBalance()
//     {
//         return balance;
//     }

//     public bool IsFrozen()
//     {
//         return isFrozen;
//     }

//     public void Deposit(decimal amount)
//     {
//         if (isFrozen)
//         {
//             Console.WriteLine("Account is frozen.");
//         }
//         else if (amount <= 0)
//         {
//             Console.WriteLine("Amount must be positive.");
//         }
//         else
//         {
//             balance += amount;
//             Console.WriteLine("Deposit successful.");
//         }
//     }

//     public void Withdraw(decimal amount)
//     {
//         if (isFrozen)
//         {
//             Console.WriteLine("Account is frozen.");
//         }
//         else if (amount <= 0)
//         {
//             Console.WriteLine("Amount must be positive.");
//         }
//         else if (amount > balance)
//         {
//             Console.WriteLine("Not enough money.");
//         }
//         else
//         {
//             balance -= amount;
//             Console.WriteLine("Withdrawal successful.");
//         }
//     }

//     public void FreezeAccount()
//     {
//         isFrozen = true;
//         Console.WriteLine("Account has been frozen.");
//     }

//     public void UnfreezeAccount()
//     {
//         isFrozen = false;
//         Console.WriteLine("Account has been unfrozen.");
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine("Account ID: " + accountId);
//         Console.WriteLine("Owner: " + OwnerName);
//         Console.WriteLine("Balance: " + balance);
//         Console.WriteLine("Frozen: " + isFrozen);
//     }
// }
