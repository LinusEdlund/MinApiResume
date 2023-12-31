using DataAccess.Data;
using DataAccess.Data.Interfaces;
using DataAccess.DbAccess;
using MininalAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IContactData, ContactData>();
builder.Services.AddSingleton<IExperienceData, ExperienceData>();
builder.Services.AddSingleton<IProjectData, ProjectData>();
builder.Services.AddSingleton<IPersonData, PersonData>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureApi();

app.Run();


