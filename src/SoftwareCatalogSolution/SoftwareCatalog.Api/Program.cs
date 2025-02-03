var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Above this line is configuring the 'internals' of our API project
var app = builder.Build(); //THE LINE IN THE SAND 
// Everything after this line is configuring how the web server handles incoming requests/responses
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // ASPNETCORE_ENVIRONMENT = Development
{
    app.UseSwagger();  //the json OPEN API spec
    app.UseSwaggerUI();  //GET /swagger/index.html
}

app.UseAuthorization();

app.MapControllers(); //this will scan your entire project for any controllers,
                      //use the attributes (HttpGet, etc) to create a 'route table' - like a phone book Reflection( the ability to have code look at itself)

app.Run(); // a blocking infinite for loop

public partial class Program { }
