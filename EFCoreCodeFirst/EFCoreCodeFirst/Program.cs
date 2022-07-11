// See https://aka.ms/new-console-template for more information


using EFCoreCodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context=new AppDbContext())
{
    _context.Products.Add(new Product
    {
        Name = "Kalem 1",
        Stock = 23,
        Price = 30000,
        Barcode = 2222
    });
    _context.Products.Add(new Product
    {
        Name = "Kalem 2",
        Stock = 23,
        Price = 30000,
        Barcode = 22221232
    });
    _context.Products.Add(new Product
    {
        Name = "Kalem 3",
        Stock = 23,
        Price = 30000,
        Barcode = 2224122
    });

    _context.SaveChanges();


    #region



    //var newProduct = new Product
    //{
    //    Name = "Kalem 33",
    //    Price = 200,
    //    Stock=23,
    //    Barcode=333
    //};

    //var product = await _context.Products.FirstAsync();
    //Console.WriteLine($"First State:{_context.Entry(product).State}");
    //_context.Entry(product).State = EntityState.Detached;
    //Console.WriteLine($"Last State:{_context.Entry(product).State}");
    //_context.Entry(newProduct).State = EntityState.Added;
    //product.Stock = 1000;
    //_context.Remove(product);
    //await _context.AddAsync(newProduct);
    //product.Name = "Kaleeeeeeeeeemmmmm";

    //Console.WriteLine($"Last State:{_context.Entry(product).State}");

    //_context.Update(new Product()
    //{   
    //    Id=3,
    //    Name="Defter",
    //});



    //var products= await _context.Products.AsNoTracking().ToListAsync();

    ////products.ForEach(p =>
    ////{
    ////    Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}-{p.Stock}");
    ////});

    //_context.ChangeTracker.Entries().ToList().ForEach(e =>
    //{
    //    if (e.Entity is Product p)
    //    {
    //        Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}-{p.Stock}");
    //    }
    //});

    ////await _context.SaveChangesAsync();
    //Console.WriteLine($"After save changes:{_context.Entry(product).State}");


    //var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;


    //    Console.WriteLine($"{p.Id}:{p.Name} - {p.Price} - {p.Stock} -- {state}");
    //});

    #endregion

}

