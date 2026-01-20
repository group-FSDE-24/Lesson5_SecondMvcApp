using Lesson5_SecondMvcApp.Services.Abstracts;
using Lesson5_SecondMvcApp.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepository, ProductRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{id?}");
});


app.Run();
