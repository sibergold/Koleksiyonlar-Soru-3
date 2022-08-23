using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Koleksiyonlar_Soru_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesli = new ArrayList();
            Console.WriteLine("Bir cümle giriniz: ");
            char[] girdi = (Console.ReadLine()).ToCharArray(); // burada gelen cümleyi harflere ayırıp oluşturduğumuz char[] girdi dizisine aktardık.
            foreach (char c in girdi)
            {
                if (c == 'a' || c == 'e' || c == 'ı' || c == 'i' || c == 'o' || c == 'ö' || c == 'u' || c == 'ü' || c == 'A' || c == 'E' || c == 'I' || c == 'İ' || c == 'O' || c == 'Ö' || c == 'U' || c == 'Ü')
                {
                    sesli.Add(c);
                }
            }
            sesli.Sort();
            foreach (char c in sesli)
            {
                Console.WriteLine("Girilen cümledeki sesli harfler:" + c);
            }
        }
    }
}