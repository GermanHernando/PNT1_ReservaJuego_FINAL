using Microsoft.EntityFrameworkCore;

namespace MVCBasico_ReservaJuego
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Aqui agrego el servicio para que la aplicacion web sepa que voy a usar Entity Framework para que EF sepa donde va a estar la base de datos que tiene que usar para leer y grabar datos

            builder.Services.AddDbContext<Context.ReservaDatabaseContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ReservaDBConnection"]));


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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}