using System;

class TreasureChest
{
    // TODO: private int gold;
    private int gold;

    // TODO: Method to deposit gold
     public void DepositGold(int amount){
        if (amount > 0)
        {
            gold += amount;
            Console.WriteLine($"{amount} gold added. Total gold: {gold}");
        }
        else
        {
            Console.WriteLine("Cannot deposit non-positive amount.");
        }
    }

    // TODO: Method to withdraw gold
     public void WithdrawGold(int amount){
        if (amount > 0)
        {
            if (amount <= gold)
            {
                gold -= amount;
                Console.WriteLine($"{amount} gold withdrawn. Remaining gold: {gold}");
            }
            else
            {
                Console.WriteLine("Not enough gold!");
            }
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount!");
        }
    }
    public TreasureChest(){
        gold = 0;
    }
}

class Program
{
    static void Main()
    {
        // TODO: Create TreasureChest object and test deposit/withdraw
        TreasureChest chest = new TreasureChest();
        chest.DepositGold(100);
        chest.WithdrawGold(40);
        chest.WithdrawGold(90);//test that exceeds amount
    }
}
