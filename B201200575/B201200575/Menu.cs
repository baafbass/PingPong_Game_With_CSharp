//************************************************************

//     AD     : ABDOUL FARIDE
     
//     SOYAD  : BASSIROU ALZOUMA

//     Sinif  : 1

//     NUMARA : B201200575

//     BÖLÜM  :  System Information    

//************************************************************/





using System;


namespace B201200575
{
    class Menu
    {
        static string Oyuncu1_adi;
        static string Oyuncu2_adi;

        public void Oyuncularin_adi_AL()
        {
            Oyuncu1_adi = Console.ReadLine();
            Oyuncu2_adi = Console.ReadLine();
            Console.Clear();
        }

        public void Oyuncu1_adi_Yaz()
        {
            Console.Write(Oyuncu1_adi);
        }

        public void Oyuncu2_adi_Yaz()
        {
            Console.Write(Oyuncu2_adi);
        }

        public void Oyun_Nasil_Oynandigini_goster()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("HOSGELDINIZ");
            Console.WriteLine();
            Console.WriteLine("Bes (5) defa oynamak sansiniz var");
            Console.WriteLine("Oyun sonunda, sadece bir tane Oyuncu kazanabilir");
            Console.WriteLine("Birinci Oyuncu Hareketler icin Klaviyeden Yukari ve Asagi tuslari kullansin");
            Console.WriteLine("Ikinci Oyuncu Hareketler icin Klaviyeden W ve Z tuslari kullansin");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("OyuncuLar Adlari girsinler ve Herhangi tus bassinlar :");
            Oyuncularin_adi_AL();
        }
    }
}
