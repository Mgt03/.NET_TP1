using System.Linq;
using Bibliotheque;

namespace dotNET.MURAT.GRANET
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new Context();
                context.Employes.ToList();
                System.Console.WriteLine("tets");
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}