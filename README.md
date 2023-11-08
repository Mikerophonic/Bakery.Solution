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

Follow these steps to set up and run the Bakery web application locally.

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
    $ cd Bakery
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
MIT License

Copyright (c) 2023 Michael Connelly

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



