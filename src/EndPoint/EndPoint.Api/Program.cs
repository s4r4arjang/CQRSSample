using EndPoint.Api.Infra.Persons;
using Microsoft.EntityFrameworkCore;
using SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;
using SampleCQRS.Core.ApplicationServices.Persons.GetPerson;
using SampleCQRS.Core.Domain.Common;
using SampleCQRS.Core.Domain.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<ICommandHandler<CreatePersonCommand , CreatePersonResult>,CreatePersonHandler>();
//builder.Services.AddScoped<ICommandHandler<EditPersonCommand, EditPersonResult>, PersonService3>();
//builder.Services.AddScoped<ICommandHandler<GetAllPersonQuery, GetAllPersonQueryResult>, PersonService3>();
//builder.Services.AddScoped<ICommandHandler<GetPersonByIdQuery, GetPersonByIdQueryResult>, PersonService3>();
//builder.Services.AddScoped<ICommandHandler<PersonDeleteCommand>, PersonService3>();

builder.Services.AddDbContext<PersonContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPersonRepository, PersonRepository>();

// Register Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}
// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // optional: customize UI with options
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
