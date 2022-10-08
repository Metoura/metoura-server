using Metoura.API.Middlewares;
using Metoura.IOC.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabase("Server=sql5.freesqldatabase.com;Database=sql5525085;Uid=sql5525085;Pwd=wbqccsgdMv;");

//(new MysqlEntityFrameworkDesignTimeServices()).ConfigureDesignTimeServices(builder.Services);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();