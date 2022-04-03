using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Occur_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int[] charac = new int[255];
            int i = 0, maxi, l;
            int ascii;
            Console.Write("\n\nFind Max occuring character in a string:\n");
            Console.Write("Input the string :");
            str=Console.ReadLine();
            l = str.Length;
            for(i=0;i<255;i++)
            { charac[i]= 0; }
            i = 0;
            while(i<l)
            { ascii = (int)str[i];
            charac[ascii]+= 1;i++; }
            maxi = 0;
            for(i=0;i<255;i++)
            { if(i!=32)
                {if (charac[i] > charac[maxi])
                        maxi = i; }
            }
            Console.WriteLine("The Highest freq of character '{0}' is appearing for number of times:{1}\n\n",(char)maxi,charac[maxi]);
        }
    }
}
