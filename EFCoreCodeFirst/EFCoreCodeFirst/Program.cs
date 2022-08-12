// See https://aka.ms/new-console-template for more information


using EFCoreCodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context=new AppDbContext())
{
    //var p3 = await _context.Products.FirstAsync(x => x.Id == 6);
    //var p2 = await _context.Products.SingleAsync(x => x.Id == 5);
    //var product = _context.Products.Find(4);

    //Console.WriteLine($"{product.Name}-{p2.Name}-{p3.Name}");

    //var p=_context.Products.Where(x => x.Stock>20).ToList();
    //p.ForEach(p =>
    //{
    //    Console.WriteLine(p.Name);
    //});


    //var urunler = from urun in _context.Products
    //              where urun.Id>5
    //              select urun;


    //var urunler = await _context.Products.Where(u=>u.Id>3).ToListAsync();

    //foreach (var item in urunler)
    //{
    //    Console.WriteLine(item.Id);
    //}

    //var urun = await _context.Products.FirstOrDefaultAsync(p => p.Id >5);

    var urun = await _context.Products.FindAsync(8);

    Console.WriteLine(urun.Name);
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

