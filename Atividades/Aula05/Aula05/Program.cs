using Modelo;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

FillCustomerData();
FillProductData();
app.Run();

static void FillCustomerData(){
    for (int i  = 1; i <= 10; i++){
        Customer customer = new(){
           Id = 1,
           Name = $"Customer {i}",
           HomeAddress = new Address(){
               Id = i+1,
               AddressType = "Casa",
               City = "Videira",
               Country = "HU3HU3BR",
               State = "SC",
               PostalCode = "89560-000",
               Street1 = "Rua da minha casa",
               Street2 = "Sua casa"
           }
        };
        CustomerData.Customers.Add(customer);

    }
}

static void FillProductData(){
    for (int i = 1; i <= 10; i++){
        Product product = new(){
            Id = 1,
            Name = $"Customer {i}"   
        };
        CustomerData.Products.Add(product);

    }
}