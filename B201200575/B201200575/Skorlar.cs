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
    class Skorlar
    {
        public int Birinci_Oyuncu_Skoru = 0;
        public int Ikinci_Oyuncu_Skoru = 0;
        public bool OyunDevam = true;

        Menu OyuncuAdi = new Menu();

        public void SonucYazdir()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.Write("{0}-{1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
        }

        public void FinalSkorYaz()
        {
            if (Birinci_Oyuncu_Skoru == 5 && Ikinci_Oyuncu_Skoru == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu1_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }

            else if (Birinci_Oyuncu_Skoru == 0 && Ikinci_Oyuncu_Skoru == 5)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu2_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }
            else if (Birinci_Oyuncu_Skoru == 4 && Ikinci_Oyuncu_Skoru == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu1_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }
           else if (Birinci_Oyuncu_Skoru == 1 && Ikinci_Oyuncu_Skoru == 4)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu2_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }
           else if (Birinci_Oyuncu_Skoru == 3 && Ikinci_Oyuncu_Skoru == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu1_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }
           else if (Birinci_Oyuncu_Skoru == 2 && Ikinci_Oyuncu_Skoru == 3)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu2_adi_Yaz();
                Console.WriteLine(" Kazandi");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                Console.Write("Skor : {0} - {1}", Birinci_Oyuncu_Skoru, Ikinci_Oyuncu_Skoru);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                OyunDevam = false;
            }
        }
    }
}
