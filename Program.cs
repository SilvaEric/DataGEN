using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Middlewares;
using GeradorDadosAPI.Services;
using GeradorDadosAPI.Services.Generators;
using GeradorDadosAPI.Services.Interfaces;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var apiKey = Environment.GetEnvironmentVariable("SEQ_API_KEY"); 
builder.Configuration["Serilog:WriteTo:0:Args:apiKey"] = apiKey;

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EmailDataBase>();
builder.Services.AddScoped<SecondNamesDataBase>();
builder.Services.AddScoped<NamesDataBase>();
builder.Services.AddScoped<PhoneNumberDataBase>();
builder.Services.AddScoped<CharListsDataBase>();
builder.Services.AddScoped<BloodTypeDataBase>();

builder.Services.AddScoped<IRegisterService, RegisterService>();
builder.Services.AddScoped<INameGenerator, NameGenerator>();
builder.Services.AddScoped<IAgeGenerator, AgeGenerator>();
builder.Services.AddScoped<IGenderGenerator, GenderGenerator>();
builder.Services.AddScoped<IEmailGenerator, EmailGenerator>();
builder.Services.AddKeyedScoped<IGenerateNoParams, PasswordGenerator>("password");
builder.Services.AddKeyedScoped<IGenerateNoParams, BloodTypeGenerator>("bloodtype");
builder.Services.AddKeyedScoped<IGenerateNoParams, HeightGenerator>("height");
builder.Services.AddKeyedScoped<IGenerateNoParams, WeightGenerator>("weight");
builder.Services.AddScoped<IPhoneNumberGenerator, PhoneNumberGenerator>();
builder.Services.AddTransient<LoggerService>();

builder.Host.UseSerilog((context, loggerConfiguration) => 
loggerConfiguration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
