using Microsoft.OpenApi.Models;

public void ConfigureServices(IServiceCollection services)
{
    // Adicionar serviços do Swagger
    services.AddSwaggerGen(c =>
    {
        // Configuração do Swagger para a versão "v1" da sua API
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minha API", Version = "v1" });
    });

    // Outros serviços...
}
