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
    class Program
    {
        static void Main(string[] args)
        {
            Oyun KafaTopuOyunu = new Oyun();
            Menu OyunMenu = new Menu();

            OyunMenu.Oyun_Nasil_Oynandigini_goster();
            KafaTopuOyunu.NesnelerBoya();
            KafaTopuOyunu.VarsayilanPozisyonuAyarla();
            KafaTopuOyunu.klaviye();
        }
    }
}
