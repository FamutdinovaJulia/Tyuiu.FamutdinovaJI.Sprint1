using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FamutdinovaJI.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        }
        public string CheckSymmetricalWords(string value)
        {
            char[] str = value.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
    }
}
