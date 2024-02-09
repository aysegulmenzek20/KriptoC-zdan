using KriptoCüzdan.repository;
using KriptoCüzdan.service.concreate;
using KriptoCüzdan.service.interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IKriptoService,KriptoService>(); //eðer sen benden interface i new lememi istersen ben sana onu arka plnadaki kripto service sýnýfnda new yapýcam
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IAlýmService,AlýmService>();
builder.Services.AddScoped<ISatýmService,SatýmService>();
builder.Services.AddDbContext<BaseDbContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
