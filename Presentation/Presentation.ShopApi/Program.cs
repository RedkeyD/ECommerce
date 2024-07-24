using Application.Abstractions.Validators;
using Application.Users;
using Application.Users.Queries.GetUser;
using Infrastructure.Foundation.EntityFramework;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder( args );

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAsyncValidator<GetUserQuery>, GetUserQueryValidator>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PgDbContext>(
    options =>
    {
        options.UseNpgsql( builder.Configuration.GetConnectionString( nameof( PgDbContext ) ) );
    } );

var app = builder.Build();

if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();
app.Run();
