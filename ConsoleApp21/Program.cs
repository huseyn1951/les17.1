using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty.Count = 99;
            Faculty grapichDesign = new Faculty();
            grapichDesign.Name = "grapich";
            char[] nameArray1 = grapichDesign.Name.ToCharArray();
            Console.WriteLine(nameArray1[0] +""+ Faculty.Count);

            Faculty programming = new Faculty();
            programming.Name = "programming";
            char[] nameArray2 = programming.Name.ToCharArray();
            Console.WriteLine(nameArray2[0]+""+Faculty.Count);

            Faculty digitalMarketing = new Faculty();
            digitalMarketing.Name = "digitalmarketing";
            char[] nameArray3 = digitalMarketing.Name.ToCharArray();
            Console.WriteLine(nameArray3[0] + "" + Faculty.Count);
        }
    }
}
