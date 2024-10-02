using Microsoft.Extensions.DependencyInjection.Extensions;
using Slim.Training.Api.DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ServiceWrapper>();
builder.Services.AddTransient<ITransientGreetingService, TransientGreetingService>();
builder.Services.AddScoped<IScopedGreetingService, ScopedGreetingService>();
builder.Services.AddSingleton<ISingletonGreetingService, SingletonGreetingService>();

//without keyedService
builder.Services.AddSingleton<INotificationService, SmsNotificationService>();
builder.Services.AddSingleton<INotificationService, EmailNotificationService>();
builder.Services.AddSingleton<INotificationService, PushNotificationService>();
builder.Services.AddSingleton<NotifierAllServices>();
builder.Services.AddSingleton<NotificationServiceConsumer>();

//with keyedService
builder.Services.AddKeyedSingleton<IKeyedNotificationService, SmsKeyedNotificationService>("sms");
builder.Services.AddKeyedSingleton<IKeyedNotificationService, EmailKeyedNotificationService>("email");
builder.Services.AddKeyedSingleton<IKeyedNotificationService, PushKeyedNotificationService>("push");
builder.Services.AddSingleton<AllKeyedNotificationServicesConsumer>();
builder.Services.AddSingleton<KeyedNotificationServicesConsumer>();

//try add
builder.Services.AddSingleton<IDummyService, DummyService>();
builder.Services.AddSingleton<IDummyService, AnotherDummyService>();
builder.Services.TryAddSingleton<IDummyService, FinalDummyService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
