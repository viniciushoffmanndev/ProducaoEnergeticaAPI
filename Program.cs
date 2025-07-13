using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configuração de serviços
ConfigureServices(builder.Services);

var app = builder.Build();

// 🌐 Configuração do pipeline HTTP
ConfigureMiddleware(app);

app.Run();


// =======================
// Métodos auxiliares
// =======================

void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Cocal API",
            Version = "v1",
            Description = "API para dados de produção de etanol, energia, biometano e CO2 verde"
        });
    });

    services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
    });
}

void ConfigureMiddleware(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors("AllowAll");
    app.UseAuthorization();
    app.MapControllers();
}


