using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazirMetotlar2_DatetimeVeMathSiniflari
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            
            
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());


            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            //math kutuphanesi

            Console.WriteLine(Math.Abs(-25));  // 25 mutlak degerini hesaplar
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));   //23. yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3));     //22. normal yuvarlar
            Console.WriteLine(Math.Floor(22.7));     //22. asagı yuvarlar

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(3,6));

            Console.WriteLine(Math.Pow(3,4));   //3^4
            Console.WriteLine(Math.Sqrt(9));    // karekok verir . 3
            Console.WriteLine(Math.Log(9));     // 9 un e tabanindaki logaritmik karşiligini verir
            Console.WriteLine(Math.Exp(3));     // e uzeri 3ü verir 
            Console.WriteLine(Math.Log10(10));





        }
    }
}
