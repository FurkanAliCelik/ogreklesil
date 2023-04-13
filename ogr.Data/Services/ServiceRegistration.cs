using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ogr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogr.Data.Services
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<OgrwebContext > (options => options.UseSqlServer("Data Source=.;Initial Catalog=ogrweb;Integrated Security=True;User Id=sa;Passwor=123456;"));

            


            services.AddScoped<GirisService>();
        }
    }
}
