<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649460011/images/BeGorgeousLogo_z8gcrb.png" />

Web application for booking :calendar: appointments in beauty :nail_care: parlours (ASP.NET 5.0).

My project for the ASP.NET Core course at SoftUni. (April 2022)

## 🔗 See live DEMO:

https://be-gorgeous.azurewebsites.net/

## :information_source: How It Works

- Guest visitor: 
  - can browse information about countries and cities where have salons;
  - can view information about salons and their beauty treatments;
  - can view information about every team in current salon.
- Logged Users:
  - can book appointments using interactive datepicker; 
  - can cancel appointments; 
  - can rate salons for which they had confirmed past appointments.  
- Manager:
  - confirms/declines users' appointments for particular salon.
- Admin:
  - creates/deletes country, city, categories, salons, beauty treatments and salons' teams;

## :hammer_and_pick: Built With

- ASP.NET Core 5.0
- Entity Framework (EF) Core 5.0.6
- Microsoft SQL Server Express
- ASP.NET Identity System
- MVC Areas with Multiple Layouts
- Razor Pages, Sections, Partial Views
- View Components
- Repository Pattern
- Auto Мapping
- Dependency Injection
- Status Code Pages Middleware
- Exception Handling Middleware
- Data Validation, both Client-side and Server-side
- Data Validation in the Models and Input View Models
- Custom Validation Attributes
- Responsive Design
- CloudinaryDotNet
- Bootstrap
- jQuery

## 📎 Seeding sample data

Would happen once you run the application, including Test Accounts:
  - User: user@begorgeous.com
  - Manager: manager@begorgeous.com
  - Admin: admin@begorgeous.com

  - password: 123456
 
## ☁️ Cloudinary Setup - optionally

#### Running without it:
You won't get an error for missing Cloudinary Credentials - it is handled by using predefined (already uploaded) image, when Cloudinary configuration is missing. So when you are creating content in admin panel, it will be added but not with the image you have chosen.
#### If you want to actually upload images, you should:

1. Add Cloudinary Credentials in `appsettings.json` in the format:
```json
  "Cloudinary": {
    "CloudName": "",
    "ApiKey": "",
    "ApiSecret": "",
    "EnvironmentVariable": ""
  }
```
2. Update the Cloudinary Setup part of `Startup.cs`'s `ConfigureServices` method as follows:
```csharp
            // Cloudinary Setup
            Cloudinary cloudinary = new Cloudinary(new Account(
                this.configuration["Cloudinary:CloudName"],
                this.configuration["Cloudinary:ApiKey"],
                this.configuration["Cloudinary:ApiSecret"]));
            services.AddSingleton(cloudinary);
```

## :wrench: DB Diagram
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649460236/images/BeGorgeousDiagram_c0umsp.png" />

## :camera: Screenshots
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649461131/images/BeGorgeous-HomePage_gr37op.png" />
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649461834/images/BeGorgeous-SalonView_emew1e.png" />
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649461833/images/BeGorgeous-TreatmentsView_vbwr7l.png" />
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649536027/images/BeGorgeous-AppointmentsView_ltxqnp.png" />
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649461967/images/BeGorgeous-ManagerView_xpezcs.png" />
<img src="https://res.cloudinary.com/be-gorgeous/image/upload/v1649462093/images/BeGorgeous-AdminView_vsvapg.png" />

## Credits
ASP.NET Core Template - [Nikolay Kostov](https://github.com/NikolayIT)
