For this task I have created an API that works with MongoDB.

In the MongoDBBackup are stored json and csv db files that hold a database called CompaniesDB with a collection called Companies. In the 
collection there are several records with Id, Name and Vat. 

This API Supports get requests by Id and Name also Get all companies. Put and Post requests are also supported.

Connection string to Mongodb instance mongodb://localhost:27017.
Target Framework is .netcoreapp 2.1 on win64.

To deploy download both the rar files and extract in a folder of choice there you will find " Mimirium.API.exe ", start it if error occurs make sure the port is not used.

Requests are as followed: 

Requests are listed here http://localhost:5000/api/company/home 

GetAllCompanies https://localhost:44364/api/company 

GetById https://localhost:44364/api/company/id?id={write id here}

GetByName https://localhost:44364/api/company/name?name={write name here}

Put https://localhost:44364/api/company Sample body {"id":" ","name":" ","vat": }

Post https://localhost:44364/api/company Sample body {"id":" ","name":" ","vat": }
