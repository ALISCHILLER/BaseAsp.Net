
//?To Level Statement

//?Factory Method
var builder = WebApplication.CreateBuilder(args);
//?Builder
var app = builder.Build();
//? Root Path
//? Strategy(Product ,Profile,Report,...)
//app.MapGet("/", () => "Hello World!");

//*Handler Types 

//! Lambda Expression 
//var handler = () => "Sample Text";
//app.MapGet("/", handler);

//! Local/Inline Function 
//string LocalFunc() => "Local Data";
//app.MapGet("/", LocalFunc);

//! Instance Method
//var hello = new HelloHandler();
//app.MapGet("/", hello.Hello);

//!Custom Route
//? Product Detail, Product list
// app.MapGet("/product/{id}", (int id) => $"Product Detail {id}");
//app.MapGet("/product/{id}", (int id) =>new Product { Id = id, Name = $"Product {id}", Price = id * 100 });


var list = new List<Product>();
list.Add(new Product { Id = 1, Name = $"Product {1}", Price = 1 * 100 });
list.Add(new Product { Id = 2, Name = $"Phone {1}", Price = 2 * 100 });
list.Add(new Product { Id = 3, Name = $"Laptop {1}", Price = 3 * 100 });
app.MapGet("/product", () => list);
//? LINQ (C# Query Data)
app.MapGet("/product/{id}", (int id) => list.FirstOrDefault(p => p.Id == id));

app.Run();


class HelloHandler
{
    public string Hello()
    {
        //* Complex Logic ...
        return "Instance Method";
    }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

}

