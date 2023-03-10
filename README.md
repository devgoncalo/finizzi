<h1 align="center"> Finizzi </h1>

<p align="center">
Feel Izzi to Track Money with Finizzi. <br/>
</p>

<p align="center">
  <a href="#-technologiess">Technologies</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-layout">Layout</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-installation">Installation</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-warnings">Warnings</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-licence">Licence</a>
</p>

<p align="center">
  <img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=49AA26&labelColor=000000">
</p>

<br>

<p align="center">
  <img src=".github/preview.jpg" width="100%">
</p>

## 🚀 Technologies

This project was developed with the following technologies:

- ``ASP.NET Core MVC`` & ``Entity Framework``
- ``Microsoft SQL Server``
- ``HTML`` & ``CSS``
- ``SyncFusion Components``
- ``Git`` & ``Github``
-  ``Figma``

## 🔖 Layout

You can view the layout of the project through [in here](https://www.figma.com/community/file/1195050524500542670). You must have an account at [Figma](https://figma.com) to access it.

## Installation

1 - Open ``appsettings.json`` and in the DevConnection and change ``instance`` to your SQL instance Server name:

``{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DevConnection": "Server=(localdb)\\instance;Database=TransactionDB;Trusted_Connection=True;MultipleActiveResultSets=True;"
  }
}``

2 - Open the Nugget Package Manager Console and add the Migration:

``Add-Migration "Initial Create"``

3 - Now in order to Create the Physical DataBase according to the Models execute the following command:

``Update-Database``

4 - Open the Microsoft SQL Server Management Studio or Visual Studio's SQL Server Object Explorer Viewer and verify if the tables were created correctly.

5 - Now press the following keys to run your app without debugging;

``control + f5``

## ⚠ Warnings

This App is focused in the use of the ASP.NET Core MVC and the Entity Framework, despite its unique and beautiful layout the app is built for large devices, and may not be responsive on many medium and small devices.

## :memo: Licence

This project is licensed under the MIT license.

---

Feito com ♥ by Gonçalo Pinto