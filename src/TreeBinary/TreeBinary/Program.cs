using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //populate tree (left as an exercise)
                var root = BuilderTree.Buider();

                Console.WriteLine("Enter Number: ");

                string number = Console.ReadLine();

                Tree<Ramification> tree = root.FirstOrDefault(x => x.Data.Number == Convert.ToInt32(number));

                TreeBinaryService service = new TreeBinaryService();

                IEnumerable<int> result = service.DoTree(tree);

                Console.WriteLine("[{0}]", String.Join(",", result.Select(x => x)));                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }                
    }
}
