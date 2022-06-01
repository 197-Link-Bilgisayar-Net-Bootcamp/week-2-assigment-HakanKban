using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Extension
{
    public static class MyExtensions
    {
        // İlk harfi büyük yapan extension metod.
        public static string LetterUpperCase(this string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
        // istenilen sayıda harfi büyük yapan overload
        public static string LetterUpperCase(this string name, int number)
        {
            return name.Substring(0,number).ToUpper() + name.Substring(number).ToLower();
            
        }
        
        // girilen kelimeyi ilk boşluktan bölüp,kelimelerin ilk harflerini büyük yapan extension metod.
        public static string GetFullName(this string name)
        {
            return name.Split(' ')[0].Substring(0, 1).ToUpper()+ name.Split(' ')[0].Substring(1).ToLower() + ' ' + name.Split(' ')[1].Substring(0,1).ToUpper() + name.Split(' ')[1].Substring(1).ToLower();
        }
        //Karesini alan extension metod.
        public static int ExponentialNumber(this int Number)
        {
            int deger = 0;
            for (int i = 0; i < Number; i++)
            {
                deger += Number;
            }
            return deger;
        }
        // Aldığı kuvvete göre üs hesaplayan overload
        public static double ExponentialNumber(this int Number, int exponentialNumber )
        {
             return  Math.Pow( Number, exponentialNumber );
     
        }
     
     
        


    }
}
