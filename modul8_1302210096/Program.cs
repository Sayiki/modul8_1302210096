// See https://aka.ms/new-console-template for more information


using modul8_1302210096;

class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        config.ReadConfig();
        if (config.Config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
        }
        else if ( config.Config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
        }

        string amount = Console.ReadLine();




    }
}
