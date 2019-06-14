using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
           var dic=new Dictionary<int, string>();
            dic.Add(1998,"Atal Bihari Vajpayee");
            dic.Add(2014,"Narendra Modi");
            dic.Add(2004,"Manmohan Singh");
            Console.WriteLine(dic[2004]);
            dic.Add(2019, "Narendra Modi");
            foreach (var q in dic.OrderBy(d=>d.Key))
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }
}
