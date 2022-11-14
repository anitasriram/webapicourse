var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Above this line is configuring the services used in your application (.net core 3.1)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //Generate the OpenAPI specification
    app.UseSwaggerUI(); //Use the swagger ui web page to show it
}

app.UseAuthorization();

app.MapControllers(); //Creates a route table in memory, uses .NET reflection

app.Run(); //this is blocking
