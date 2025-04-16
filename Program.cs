using modul8_103022300058;
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(String[] args) 
    {
        BankTransferConfig pengaturan = new BankTransferConfig().LoadConf();
        Console.Write("Ingin mengubah bahasa? (y/n): ");
        string input = Console.ReadLine();

        int uang;

        if (input.ToLower() == "y")
        {
            pengaturan.GantiBahasa();
            Console.WriteLine($"New language / bahasa sekarang: {pengaturan.lang}" );
        }

        if (pengaturan.lang == "id")
        {
            Console.Write($"\n{pengaturan.lang} =  Masukkan jumlah uang yang akan di-transfer: ");
            uang = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.Write($"\n{pengaturan.lang} =  Please insert the amount of money to transfer: ");
            uang = Convert.ToInt32(Console.ReadLine());
        }

        if (uang <= pengaturan.transfer.threshold || uang == pengaturan.transfer.threshold)
        {
            Console.Write($"biaya transfer adalah: {pengaturan.transfer.low_fee}");
        }
        else if(uang >= pengaturan.transfer.threshold)
        {
            Console.Write($"biaya transfer adalah: {pengaturan.transfer.high_fee}");
        }

        Console.WriteLine("");
        int i = 1;
        foreach (var data in pengaturan.methods)
        {
            
            Console.WriteLine($"{i}. {data}");
            i++;
        }
        string ya

        if (pengaturan.lang == "id")
        {
            Console.Write($"\n{pengaturan.lang} => Ketik {pengaturan.confirmation.id}: ");
            ya = Console.ReadLine();
        }
        else
        {
            Console.Write($"\n{pengaturan.lang} =>   Please type {pengaturan.confirmation.en}");
            ya = Console.ReadLine();
        }

        if (ya == "ya")
        {
            Console.WriteLine("behasil transfer");
        }
        else {
            Console.WriteLine("Sucsess transfer");
        }
    }
}