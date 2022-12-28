//************************************************************

//     AD     : ABDOUL FARIDE

//     SOYAD  : BASSIROU ALZOUMA

//     Sinif  : 1

//     NUMARA : B201200575

//     BÖLÜM  :  System Information    

//************************************************************/






using System;
using System.Threading;

namespace B201200575
{
    class Oyun
    {
        Oyuncular oyuncular = new Oyuncular();
        Skorlar SKOR = new Skorlar();
        Menu OyuncuAdi = new Menu();

        public bool Yukari_Top_Direksyonu = true;
        public bool Saga_Top_Direksyonu = false;
        public int X_TopPozisyonu = 0;
        public int Y_TopPozisyonu = 0;

        public void NesnelerBoya()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        public void VarsayilanPozisyonuAyarla()
        {
            oyuncular.Birinci_Oyuncu_Pozisyonu = Console.WindowHeight / 2 - oyuncular.Birinci_Oyuncu_Kafa_Uzunlugu / 2;
            oyuncular.Ikinci_Oyuncu_Pozisyonu = Console.WindowHeight / 2 - oyuncular.Ikinci_Oyuncu_Kafa_Uzunlugu / 2;
            OrtaSahadaTopAyarla();
        }

        public void OrtaSahadaTopAyarla()
        {
            X_TopPozisyonu = Console.WindowWidth / 2;
            Y_TopPozisyonu = Console.WindowHeight / 2;
        }

        public void TopCiz()
        {
            oyuncular.Konumda_Yazdir(X_TopPozisyonu, Y_TopPozisyonu, 'O');
        }

        public void TopHareketEttir()
        {
            if (Y_TopPozisyonu == 0)
            {
                Yukari_Top_Direksyonu = false;
            }
            if (Y_TopPozisyonu == Console.WindowHeight - 1)
            {
                Yukari_Top_Direksyonu = true;
            }
            if (X_TopPozisyonu == Console.WindowWidth - 1)
            {
                OrtaSahadaTopAyarla();
                Saga_Top_Direksyonu = false;
                Yukari_Top_Direksyonu = true;
                SKOR.Birinci_Oyuncu_Skoru++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu1_adi_Yaz();
                Console.WriteLine(" Gol Atti");
                Console.ReadKey();
            }
            if (X_TopPozisyonu == 0)
            {
                OrtaSahadaTopAyarla();
                Saga_Top_Direksyonu = true;
                Yukari_Top_Direksyonu = true;
                SKOR.Ikinci_Oyuncu_Skoru++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                OyuncuAdi.Oyuncu2_adi_Yaz();
                Console.WriteLine(" Gol Atti");
                Console.ReadKey();
            }
            if (X_TopPozisyonu < 3)
            {
                if (Y_TopPozisyonu >= oyuncular.Birinci_Oyuncu_Pozisyonu && Y_TopPozisyonu < oyuncular.Birinci_Oyuncu_Pozisyonu + oyuncular.Birinci_Oyuncu_Kafa_Uzunlugu)
                {
                    Saga_Top_Direksyonu = true;
                }
            }
            if (X_TopPozisyonu >= Console.WindowWidth - 3 - 1)
            {
                if (Y_TopPozisyonu >= oyuncular.Ikinci_Oyuncu_Pozisyonu && Y_TopPozisyonu < oyuncular.Ikinci_Oyuncu_Pozisyonu + oyuncular.Ikinci_Oyuncu_Kafa_Uzunlugu)
                {
                    Saga_Top_Direksyonu = false;
                }
            }
            if (Yukari_Top_Direksyonu)
            {
                Y_TopPozisyonu--;
            }
            else
            {
                Y_TopPozisyonu++;
            }

            if (Saga_Top_Direksyonu)
            {
                X_TopPozisyonu++;
            }
            else
            {
                X_TopPozisyonu--;
            }
        }

        public void klaviye()
        {
            while (SKOR.OyunDevam)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        oyuncular.BirinciOyuncuYukariHareketEttir();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        oyuncular.BirinciOyuncuAsagiHareketEttir();
                    }
                    if (keyInfo.Key == ConsoleKey.W)
                    {
                        oyuncular.IkinciOyuncuYukariHareketEttir();
                    }
                    if (keyInfo.Key == ConsoleKey.Z)
                    {
                        oyuncular.IkinciOyuncuAsagiHareketEttir();
                    }
                }

                TopHareketEttir();
                Console.Clear();
                oyuncular.BirinciOyuncuKafaCiz();
                oyuncular.IkinciOyuncuKafaCiz();
                TopCiz();
                SKOR.SonucYazdir();
                SKOR.FinalSkorYaz();
                Thread.Sleep(20);
            }
        }
    }
}
