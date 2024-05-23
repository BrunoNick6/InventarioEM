using InventarioEM.NewFolder;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
      /*  var serviceProvider = new ServiceCollection()
            .AddDbContext<InventarioContext>(options =>
                options.UseNpgsql("your_connection_string_here"))
            .AddTransient<IAreaRepository, AreaRepository>()
            .AddTransient<IAreaService, AreaService>()
            // Agrega los repositorios y servicios para las demás tablas
            .BuildServiceProvider();   */

        var areaService = serviceProvider.GetService<AreaService>();

        
        var areas = areaService.GetAllAreas();
        foreach (var area in areas)
        {
            Console.WriteLine($"Id: {area.Id}, Nombre: {area.Nombre}");
        }
    }
}



