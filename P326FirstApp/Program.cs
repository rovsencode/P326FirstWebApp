var builder = WebApplication.CreateBuilder(args);
//services
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapControllerRoute(
   name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
