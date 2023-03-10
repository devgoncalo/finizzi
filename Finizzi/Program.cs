using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpAaVhdX2NLfUNwT2JadVx0ZCQ7a15RRnVfQV1rSXhSdUdmWnxceA==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRGQmRWfFN0RnNfdV9zfldCcC0sT3RfQF5jSn5bdkNiWn1bc3BdTg==;ORg4AjUWIQA/Gnt2VVhkQlFacldJWXxOYVF2R2BJeVRxd19EZEwgOX1dQl9gSX1TfkVlWHxcdXdTQ2g=;MTI3OTcwOUAzMjMwMmUzNDJlMzBkUVJUQjNsbE14TldrcmxVY2d2TzZvR1ZZbENnTFZwZ0VINklFZUN3WHFBPQ==;MTI3OTcxMEAzMjMwMmUzNDJlMzBGN3o0RFdXYlRvcEtaSzRmMW1ObDk5a0E5dlkrRGp3ZmE5Y2djWi9kL05VPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmdWeUx0RWFab1h6dVZMYlhBNQtUQF1hSn5Qdk1jX35dcnFRRWBU;MTI3OTcxMkAzMjMwMmUzNDJlMzBIRU8xRTZ0UXY0S0NzR0E4dS9lbVJ0a1l2TjN3K0MzU1I1YWNtcThqZnpRPQ==;MTI3OTcxM0AzMjMwMmUzNDJlMzBLd1A3bVkwcmFzVEFsVHJrQS9admxTeSs2MzU0S3hKaU9pTWVNQ05FNzd3PQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJWXxOYVF2R2BJeVRxd19EZEwgOX1dQl9gSX1TfkVlWHxcdXBcTmg=;MTI3OTcxNUAzMjMwMmUzNDJlMzBFMjMyZWJ2YVVzUUdlMktvckVkekdtVEdUZldCTFVJeHhYMGF2dmd0UHU0PQ==;MTI3OTcxNkAzMjMwMmUzNDJlMzBuMnVjQ2gzM29yOTNUWjJsbmVGOUZVcm5vWnFCbkh1UjBJaktKcExZVWtFPQ==;MTI3OTcxN0AzMjMwMmUzNDJlMzBIRU8xRTZ0UXY0S0NzR0E4dS9lbVJ0a1l2TjN3K0MzU1I1YWNtcThqZnpRPQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
