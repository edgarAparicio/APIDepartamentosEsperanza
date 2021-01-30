using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace APIDepartamentosEsperanza
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DepartamentosEsperanzaContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DepartamentosEsperanzaConnectionString")));

            services.AddControllers();
            services.AddSwaggerGen(setupAction => 
            {
                setupAction.SwaggerDoc
                (
                    "DepartamentOpenAPISpecification",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Departments API",
                        Version = "1"
                    }
                );

                //Obtenemos el directorio actual
                var basePath = AppContext.BaseDirectory;
                //Obtenemos el nombre de la dll por medio de reflexi�n
                var assemblyName = System.Reflection.Assembly
                              .GetEntryAssembly().GetName().Name;
                //Al nombre del assembly le agregamos la extensi�n xml
                var fileName = System.IO.Path
                              .GetFileName(assemblyName + ".xml");
                //Agregamos el Path, es importante utilizar el comando
                // Path.Combine ya que entre windows y linux 
                // rutas de los archivos
                // En windows es por ejemplo c:/Uusuarios con / 
                // y en linux es \usr con \
                var xmlPath = Path.Combine(basePath, fileName);
                setupAction.IncludeXmlComments(xmlPath);
            });

            
        }

         
        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint(
                    "/swagger/DepartamentOpenAPISpecification/swagger.json",
                    "Departament API"
                    );
                //Permite que al ejecutar la aplicacion y la pantalla a mostrar sea la UI de swagger
                setupAction.RoutePrefix = "";
            });

                

        }
    }
}
