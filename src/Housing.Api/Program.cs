using Housing.Domain.RepositoryInterfaces;
using Housing.Domain.Services;
using Housing.Infrastructure.DumpPropertiesRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPropertiesRepository, DumpPropertiesRepository>();
builder.Services.AddSingleton<HousingService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "DevPolicy",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200");
        }
    );
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.UseCors("DevPolicy");
app.Run();
