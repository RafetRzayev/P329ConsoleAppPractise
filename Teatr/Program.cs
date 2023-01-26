using System.Text;

namespace Teatr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder(s);
            sb.Insert(0, ' ');
            char[] chars = new char[sb.Length];
            //ab cd ef
            //ef cd ab 
          
            int count = 0, k = 0;
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                count++;

                var c = sb[i];

                if (sb[i]==' ')
                {
                    sb.CopyTo(i + 1, chars, k, count - 1);
                    k += count;
                    chars[k - 1] = ' ';
                    count = 0;
                    
                }
            }

            Console.WriteLine(new String(chars));
        }
    }
}