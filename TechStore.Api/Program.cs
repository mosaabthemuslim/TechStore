using TechStore.Domain.User;
using TechStore.Infrastructure.CollectionExtension;
using TechStore.Infrastructure.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<TechStoreDBContext>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("api/identity")
        .WithTags("Identity")
        .MapIdentityApi<User>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
