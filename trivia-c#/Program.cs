using Application.Interfaces.Configs;
using Application.Interfaces.Histories;
using Application.Interfaces.Partidas;
using Application.Interfaces.Questions;
using Application.Interfaces.Users;
using Application.Mappers;
using Application.Services;
using Infrastructure.Mongo.Commands;
using Infrastructure.Mongo.Querys;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson.Serialization.Serializers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// Habilitar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173", "https://triviados-dev.netlify.app")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(option => option.UseMongoDB(connectionString));


builder.Services.AddScoped<IConfigQuery, ConfigQuery>();
builder.Services.AddScoped<IConfigCommand, ConfigCommand>();
builder.Services.AddScoped<IConfigService, ConfigService>();
builder.Services.AddScoped<IConfigMapper, ConfigMapper>();

builder.Services.AddScoped<IUserQuery, UserQuery>();
builder.Services.AddScoped<IUserCommand, UserCommand>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserMapper, UserMapper>();

builder.Services.AddScoped<IHistoryQuery, HistoryQuery>();
builder.Services.AddScoped<IHistoryCommand, HistoryCommand>();
builder.Services.AddScoped<IHistoryService, HistoryService>();
builder.Services.AddScoped<IHistoryMapper, HistoryMapper>();

builder.Services.AddScoped<IQuestionQuery, QuestionQuery>();
builder.Services.AddScoped<IQuestionCommand, QuestionCommand>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IQuestionMapper, QuestionMapper>();

builder.Services.AddScoped<IPartidaService, PartidaService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
