using System.Collections.Generic;
using System.Linq;

namespace TreeBinary
{
    public static class BuilderTree
    {
        public static IEnumerable<Tree<Ramification>> Buider()
        {
            ICollection<Tree<Ramification>> result = new List<Tree<Ramification>>();

            for (int i = 1; i <= 13; i++)
            {
                Tree<Ramification> tree = new Tree<Ramification>
                {
                    Data = new Ramification { Name = i.ToString(), Number = i }
                };

                result.Add(tree);
            }

            foreach (var item in result)
            {
                switch (item.Data.Number)
                {
                    case 2:
                        item.Left = result.FirstOrDefault(x => x.Data.Number == 4);
                        break;
                    case 3:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 7);
                        break;
                    case 4:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 1);
                        break;
                    case 5:
                        item.Left = result.FirstOrDefault(x => x.Data.Number == 11);
                        break;
                    case 6:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 11);
                        break;
                    case 7:
                        item.Left = result.FirstOrDefault(x => x.Data.Number == 1);
                        break;
                    case 8:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 10);
                        break;
                    case 9:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 13);
                        break;
                    case 10:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 4);
                        break;
                    case 11:
                        item.Left = result.FirstOrDefault(x => x.Data.Number == 7);
                        break;
                    case 13:
                        item.Left = result.FirstOrDefault(x => x.Data.Number == 12);
                        break;
                    case 12:
                        item.Right = result.FirstOrDefault(x => x.Data.Number == 2);
                        break;
                }
            }

            return result;
        }
    }
}
