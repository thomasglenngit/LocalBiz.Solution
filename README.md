# _Local Business Api_

#### _C#/.NET Project for [Epicodus](https://www.epicodus.com/), 2020.08.21_

#### By **Thomas Glenn**

## Description
A weekly code review project for Epicodus school, which allows the user to retrieve information on local buisinesses via their browser command line on this host's local URL. 


The following sitemap explains this database query relationship.

## Database Structure
<img src="LocalBiz/wwwroot/assets/images/Biz.png"          style="float: left; margin-right: 10px;" />

## Specifications

| Spec |
|:--------- |
| The program will contain database of local businesses including names, addresses, types, and emails |  
| The program will construct an Application Programming Interface (API) to query the database  | 
| The program will test the queries using the Postman application |
| The program will incorporate a pagination feature to limit the returned entries to three per page. |

## Known Bugs
*    None, yet...

## Setup/Installation Requirements
#### View Online
Visit the GitHub Pages by clicking on the following link or by typing it in your web browser. 
<url:>

https://github.com/thomasglenngit/LocalBiz.Solution

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone `

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet restore`.
Once 'restore' is run, enter `$ dotnet build`.

### Packages
The following packages must be added to run this application:
1. In the CLI (Command Line Interface), enter the command: `dotnet new webapi --framework netcore app2.2`

#### MySQL Setup
In order to view and use the functionality of this project you must,
1. Install MySQL on your computer. If you don't have it, you can download the .dmg file here:
https://dev.mysql.com/downloads/file/?id=484914. You'll need to create a password.

2. Install MySQL Workbench on your computer. If you don't have it, you can download it here:
https://dev.mysql.com/downloads/file/?id=484391.

3. Open MySQL Workbench and select the Local instance 3306 server. 

#### Importing this file:
1. Open your MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.

2. In Import Options select Import from Self-Contained File.

3. Navigate to `local_biz`.

Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end.
In this case local_biz_test.
Click Ok.
Click Start Import.

Reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.


#### Query
The following is the query information for access to this database on MySQL Workbench.
```
CREATE DATABASE `local_biz` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
CREATE TABLE `Bizs` (
  `BizId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Address` longtext,
  `Type` longtext,
  `Url` longtext,
  PRIMARY KEY (`BizId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `Restos` (
  `RestoId` int(11) NOT NULL AUTO_INCREMENT,
  `RName` longtext,
  `RAddress` longtext,
  `RType` longtext,
  `RUrl` longtext,
  PRIMARY KEY (`RestoId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

```

#### Entity
Entity is a framework which coordinates the properties associated with the project models, and the corresponding datatables stored in MySQL. In order to keep the database refreshed with user inputs and possible changes to the application models, the following commands must be made after these inputs and changes:

1. In the terminal command line, enter: `dotnet ef migration add (name of migration)`. You can name the migration what you will, but remember that each new migration must have a unique name. Best practices are to name the first migration, "Initial", then "Secondary", etc. Also note that the first letter of the migration name should always be capitalized. If all goes well, the terminal will respond with the affirmation, "Done."

2. Following the migration the database must be updated with the following command: `dotnet ef database update`. Again, if all goes well, after entering this command, the terminal will affirm the update and migration by displaying the migration with a unique migration number and the affirmation, "Done".

3. Check to see that the migration appears in MySQl Workbench, as well as newly formed "Migrations" folder in your VSCode editor.


### API Queries Using Postman
"Postman" is an application for querying local and remote databases. It can be downloaded at: https://www.postman.com/downloads/.

To query the LocalBiz database, 
1. In your CLI (Command Line Interface), enter `dotnet run`.
2. Open Postman and locate the request field. 
3. To the left of the field, make sure that the query type is set to "GET". 
4. Below the request field, make sure that the data type is set to "raw", and the drop-down menu is set to "text".
5. Enter the following URL in the request field: `http://localhost:5000/api/Bizs`. 
6. Press the big blue button that says, "Send". This will display all the "Businesses" listed in the database in the lowest field on the page.
7. To view all the Restaurants in the database, enter the following URL in the request field: `http://localhost:5000/api/Restos`.
8. To view all Businsesses and Restaurants in the database, enter the following URL in the request field: `http://localhost:500/api/Bizs&Restos`.

### Pagination 
To adjust the number of database entries viewed on Postman, 
1. enter the following URL in the request line: `http://localhost:5000/api/Restos/page` or `http://localhost:5000/api/Bizs/page`.
2. The pagination is set to three entries per page. To change this, go to the project file, in UrlQuery.cs, change the number `3` on lines 21 and twice on line 27 to desired number of entries.

### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
* Visual Studio Code (code editor)
* C#/.NET
* MS Entity
* Postman
* GitHub
* MacOS Catalina
* MySQL Workbench
* CSS
* .html

## License
This software is licensed under the MIT license. Copyright (c) 2020 Thomas Glenn.

