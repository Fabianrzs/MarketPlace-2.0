using Site.Extensions;
using Site.Middelwors;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configutation = builder.Configuration;

services.AddControllers();
services.AddEndpointsApiExplorer();

IoCExtensions.AddDependency(services, configutation);
JwtExtensions.AddJwt(services, configutation);
SwaggerExtensions.AddSwagger(services);
MappingExtensions.AddMapping(services);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
