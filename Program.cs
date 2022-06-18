internal class Program
{
    private static void Main(string[] args)
    {
       
        // Ekrana girilen sayıya kadar olan tek sayıları yazdır.
        Console.WriteLine(" Lütfen Bir Sayı Giriniz:");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 0; i <= sayac; i++)
        {
            if (i%2 == 1)
                Console.WriteLine(i);
        }

        //1 ile 100 arasındaki tek ve çift sayıların ayrı ayrı toplamını ekrana yazdır.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i%2 == 0)
               ciftToplam += i; // ciftToplam = ciftToplam + i;
            else 
               tekToplam += i; // tekToplam = tekToplam + i; 
        }

            Console.WriteLine("Çift Toplam: " + ciftToplam);
            Console.WriteLine("Tek Toplam: " + tekToplam);
        
        // break, continue

        for (int i = 1; i <= 10; i++)
        {
            if (i==4)
                break;
            Console.WriteLine(i);
        }

        for (int i = 1; i <= 10; i++)
        {
            if (i==4)
               continue;
            Console.WriteLine(i);
        }

                
    }
}