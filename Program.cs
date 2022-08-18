var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(e =>
{
    // http://localhost:5293/home/index
    e.MapControllerRoute("default", "{controller}/{action}");
});
app.Run();