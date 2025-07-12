using Portafolio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();

var app = builder.Build();

// Prioridad:
// 1️⃣ Si Render pasa PORT → usarlo
// 2️⃣ Si dotnet recibe --urls → lo respeta automáticamente
// 3️⃣ Si nada está definido → usar puerto 5000
var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrEmpty(port))
{
    app.Urls.Add($"http://*:{port}");
    Console.WriteLine($"🔊 Usando puerto dinámico: {port}");
}
else
{
    Console.WriteLine($"✅ Usando configuración por defecto o --urls");
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Omitir redirección HTTPS para Render
    // app.UseHttpsRedirection();
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
