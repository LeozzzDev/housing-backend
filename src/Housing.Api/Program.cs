using Housing.Domain.RepositoryInterfaces;
using Housing.Domain.Services;
using Housing.Infrastructure.DumpPropertiesRepository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IPropertiesRepository, DumpPropertiesRepository>();
builder.Services.AddSingleton<HousingService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
