using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public static string toArray(string srr)
        {
            string[] words = srr.Split(' ');

            for (int i = 0; i < words.Length; i++) ;
        }
        public static string Reverse(string s)
        {
            char[] str = s.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
    }
}
