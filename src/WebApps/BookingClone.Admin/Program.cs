<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using System.Reflection;
using BookingClone.Application;
using BookingClone.Serilog;
using FluentValidation;
using FluentValidation.AspNetCore;
=======
using System.Reflection;

using BookingClone.Application;
using BookingClone.Serilog;
=======
using System.Reflection;

using BookingClone.Application;
using BookingClone.Serilog;
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using FluentValidation;
using FluentValidation.AspNetCore;

<<<<<<< HEAD
>>>>>>> city handler
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookingClone.Admin.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BookingCloneAdminContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("IdentityConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<BookingCloneAdminContext>();

builder.Services.AddRazorPages();

=======
using BookingClone.Serilog;
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

>>>>>>> first commit
builder.WebHost.ConfigureKestrel(options =>
{
    options.AddServerHeader = false;
    options.ConfigureHttpsDefaults(s => s.AllowAnyClientCertificate());
    options.ConfigureEndpointDefaults(o => o.Protocols = HttpProtocols.Http1AndHttp2AndHttp3);
});

builder.Host.UseSerilog(Serilogger.Configure);

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> city handler
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
builder.Services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters()
    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);

=======
// Add services to the container.
>>>>>>> first commit
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
<<<<<<< HEAD
{   
=======
{
>>>>>>> first commit
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
<<<<<<< HEAD
app.MapRazorPages();
=======
>>>>>>> first commit

app.Run();
