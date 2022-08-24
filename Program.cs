var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor 
builder.Services.AddControllersWithViews();

var aplicacion = builder.Build();

// Configuracion el HTTP
if (!aplicacion.Environment.IsDevelopment())
{
    aplicacion.UseExceptionHandler("/Home/Error");
    aplicacion.UseHsts();
}
aplicacion.UseHttpsRedirection();
aplicacion.UseStaticFiles();
aplicacion.UseRouting();
aplicacion.UseAuthorization();
aplicacion.MapControllerRoute(name: "default", pattern: "{controller = Home}/{action = Index}/{id?}");
aplicacion.Run();