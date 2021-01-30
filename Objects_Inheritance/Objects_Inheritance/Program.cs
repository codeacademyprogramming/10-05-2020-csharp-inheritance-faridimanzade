using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter key words (basic/pro/expert)");
            string choice = Console.ReadLine();

            /*DocumentProgram docProgram = new DocumentProgram();*/
            DocumentProgram docProgram = null;

            if (choice.Equals("basic"))
            {
                docProgram = new DocumentProgram();
            }
            else if (choice.Equals("pro"))
            {
                docProgram = new ProDocumentProgram();
            }
            else if (choice.Equals("expert"))
            {
                docProgram = new ExpertDocument();
            }
            else
            {
                Console.WriteLine("Invalid input");
                /*return;*/
            }

            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
    }
}
