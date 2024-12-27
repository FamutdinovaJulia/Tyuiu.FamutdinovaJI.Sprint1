using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task6.V5.Lib
{
    public class DataService
    {
\

        }

        public static string toArray(string srr)
        {
            char[] norm = srr.ToCharArray();
            return new string (norm);   
        }
        public static string Reverse(string s)
        {
            char[] str = s.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
    }
}
