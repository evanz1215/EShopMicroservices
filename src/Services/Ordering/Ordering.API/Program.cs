using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// add services to the container
// Infrastructure - EF Core
// Application - MediatR
// API - Carter, HealthChecks

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();


app.Run();
