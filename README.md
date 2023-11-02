# Pierre's Bakery

This is a web application for managing treats for a (fictional) bakery.

#### By Michael G Connelly

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server 
- Razor pages
- C#
- HTML, CSS, and JavaScript
- Identity

## Description

This project was created as my fifth independent project, "Authentication with Identity", in the C# / .Net course at Epicodus. It demonstrates my understanding of building an MVC app, connecting it to a database with many-to-many relationships using Entity Framework Core, and using authentication with Identity.

## Setup and Installation

Follow these steps to set up and run the Hair Salon web application locally.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) installed on your machine.
- SQL Server (or another compatible database) installed.

### Clone the Repository

```bash
git clone https://github.com/Mikerophonic/Bakery.Solution.git
cd Bakery
```

### Setup database

Create a new file named `appsettings.json` in the project's root directory:

```bash
   $ touch appsettings.json
```

Open the appsettings.json file and insert the following code. Replace [YOUR-USERNAME] and [YOUR-MYSQL-PASSWORD] with your MySQL username and password:

```bash
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=your_database_name;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
    }
```
Navigate to the project directory:
```bash
    $ cd Factory
```

<b>Create Database:</b> 
```
$ dotnet ef migrations add Initial
$ dotnet ef database update
```

Start the project in development mode with a watcher using the following command:
```bash
    $ dotnet watch run
```

## Known Bugs

No known bugs.


## License
MIT
Copyright (c) 2023 Michael G Connelly





