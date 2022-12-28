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
    class Oyuncular
    {
        public int Birinci_Oyuncu_Kafa_Uzunlugu = 7;
        public int Ikinci_Oyuncu_Kafa_Uzunlugu = 7;

        public int Birinci_Oyuncu_Pozisyonu = 0;
        public int Ikinci_Oyuncu_Pozisyonu = 0;

        public void BirinciOyuncuKafaCiz()
        {
            for (int y = Birinci_Oyuncu_Pozisyonu; y < Birinci_Oyuncu_Pozisyonu + Birinci_Oyuncu_Kafa_Uzunlugu; y++)
            {
                Konumda_Yazdir(0, y, ']');
                Konumda_Yazdir(1, y, ']');
            }
        }

        public void IkinciOyuncuKafaCiz()
        {
            for (int y = Ikinci_Oyuncu_Pozisyonu; y < Ikinci_Oyuncu_Pozisyonu + Ikinci_Oyuncu_Kafa_Uzunlugu; y++)
            {
                Konumda_Yazdir(Console.WindowWidth - 1, y, '[');
                Konumda_Yazdir(Console.WindowWidth - 2, y, '[');
            }
        }

        public void BirinciOyuncuAsagiHareketEttir()
        {
            if (Birinci_Oyuncu_Pozisyonu < Console.WindowHeight - Birinci_Oyuncu_Kafa_Uzunlugu)
            {
                Birinci_Oyuncu_Pozisyonu++;
            }
        }

        public void BirinciOyuncuYukariHareketEttir()
        {
            if (Birinci_Oyuncu_Pozisyonu > 0)
            {
                Birinci_Oyuncu_Pozisyonu--;
            }
        }

        public void IkinciOyuncuAsagiHareketEttir()
        {
            if (Ikinci_Oyuncu_Pozisyonu < Console.WindowHeight - Ikinci_Oyuncu_Kafa_Uzunlugu)
            {
                Ikinci_Oyuncu_Pozisyonu++;
            }
        }

        public void IkinciOyuncuYukariHareketEttir()
        {
            if (Ikinci_Oyuncu_Pozisyonu > 0)
            {
                Ikinci_Oyuncu_Pozisyonu--;
            }
        }

        public void Konumda_Yazdir(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
