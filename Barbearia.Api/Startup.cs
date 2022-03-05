using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using Barbearia.IoC;
namespace Barbearia.Api;
 
public class Startup {
    public Startup(IConfiguration configuration) {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services) { 
        services.AddControllers();
        services.AddRouting(option => option.LowercaseUrls = true);

        services.AddSwaggerGen(c => {
            c.SwaggerDoc("v1", new OpenApiInfo {
                Title = "BarbeariaPeu.Api",
                Version = "v1",
                Description = "<MUDAR AQUI><br>Repositório: <a href='link' target='_blank'>Barbearia</a>",
                Contact = new OpenApiContact {
                    Name = "Wellington N.",
                    Email = "wellingtonwsn2015@gmail.com"
                },
            });
        });

        services.ConfigureAppDependecies(Configuration);
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
        }

        app.UseSwagger();
        app.UseSwaggerUI(
            c => {
                c.DocumentTitle = "Barbearia.Api Swagger Docs";
                c.DisplayRequestDuration();
                c.DocExpansion(DocExpansion.List);
                c.EnableDeepLinking();
                c.ShowExtensions();
                c.ShowCommonExtensions();
                c.EnableValidator();
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", $"Barbearia.Api V1");
                
            });

        app.UseRouting();

        app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
        });
    }

}