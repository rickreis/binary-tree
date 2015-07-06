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
                var tree = BuilderTree.Buider();

                Console.WriteLine("Enter Number: ");

                string number = Console.ReadLine();                

                TreeBinaryService service = new TreeBinaryService();

                IEnumerable<int> result = service.DoTree(tree, Convert.ToInt32(number));

                Console.WriteLine("[{0}]", String.Join(",", result.Select(x => x)));                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }                
    }
}
