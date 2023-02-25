using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);


builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, nextMiddleware) =>
{
    if (context.Response.Headers.ContainsKey("x-correlation-id"))
        context.Response.Headers["x-correlation-id"] = "test " + context.Request.Headers["x-correlation-id"];
    else
        context.Response.Headers.Add("x-correlation-id", "test " + context.Request.Headers["x-correlation-id"]);
    await nextMiddleware();

});
app.UseHttpLogging();

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
