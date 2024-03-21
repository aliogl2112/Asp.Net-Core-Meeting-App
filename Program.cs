var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//{controller=Home}/{action=Index}/{id?}
app.MapDefaultControllerRoute();

// app.MapControllerRoute(
//     name:"default",
//     pattern:"{controller=Home}/{action=Index}/{id?}"
// );

//mvc
//rest-api
//razor pages

app.Run();
