using Domain.Intefaces;
using Domain.Model;
using Infrastructure.DataAccess;

namespace Warehouse
{
    internal class Program
    {
        private static readonly DbContextProduct _ProductDB = new(@"C:\Users\User\source\repos\Infrastructure\DataAccess\States\ProductsDB.json");
        static void Main(string[] args)
        {
            Console.WriteLine("Tanlang:\n1.Read\n2.Add\n3.Delete\n4.Update");

            if (byte.TryParse(Console.ReadLine(), out byte select))
            {
                switch (select)
                {
                    case 1:
                        {
                            IList<IProduct> products = _ProductDB.GetAll();
                            //foreach (IProduct item in products)
                            //{
                            //    Console.WriteLine();
                            //}
                        }
                        break;
                    case 2:
                        {

                            _ProductDB.AddRange(new List<IProduct>()
                            {
                                new Product()
                            {
                                Id=Guid.NewGuid(),
                                Name = "Kefir",
                                Description = "fddsfsdfs",
                                Data = new List<IProductData>()
                                {
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=100
                                   },
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=10
                                   },
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=50
                                   }
                                }
                            },
                                 new Product()
                            {
                                Id=Guid.NewGuid(),
                                Name = "Sut",
                                Description = "Description",
                                Data = new List<IProductData>()
                                {
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=34
                                   },
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=67
                                   },
                                   new ProductData()
                                   {
                                      CreatedDate=DateOnly.MinValue,
                                      ExpiryDate=DateOnly.MinValue.AddDays(5),
                                      Count=340
                                   }
                                }
                            }
                            });
                        }
                        break;
                }
            }
        }
    }
}