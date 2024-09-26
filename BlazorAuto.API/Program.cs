using Microsoft.EntityFrameworkCore;
using BlazorAuto.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Configure the database
// Add services to the container with DbContext pooling.
builder.Services.AddDbContextPool<APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

var group = app.MapGroup("/customers");

group.MapGet("/", async Task<Customer[]> (APIContext db) => 
    await db.Customers.AsNoTracking().ToArrayAsync());

group.MapGet("/{id}", async ValueTask<Customer?> (int id, APIContext db) =>
    await db.Customers.FindAsync(id));

    //await db.Customers.SingleOrDefaultAsync(c => c.CustomerID == id));

//group.MapGet("/{id}", async Task<Results<Ok<Customer>, NotFound>> (int id, APIContext db) =>
//    await db.Customers.FindAsync(id) is Customer customer
//        ? TypedResults.Ok(customer)
//        : TypedResults.NotFound());

app.Run();
