var builder = WebApplication.CreateBuilder(args);

var assembly = typeof(Program).Assembly;
builder.Services.AddCarter();

// add sevices to the container.
var app = builder.Build();


// Configure the HTTP request pipeline.

app.Run();
