using Microsoft.OpenApi.Models;

public void ConfigureServices(IServiceCollection services)
{
    // Adicionar servi�os do Swagger
    services.AddSwaggerGen(c =>
    {
        // Configura��o do Swagger para a vers�o "v1" da sua API
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minha API", Version = "v1" });
    });

    // Outros servi�os...
}
