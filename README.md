For this task I have created an API that works with MongoDB.

In the MongoDBBackup are stored json and csv db files that hold a database called CompaniesDB with a collection called Companies. In the 
collection there are several records with Id, Name and Vat. 

This API Supports get requests by Id and Name also Get all companies. Put and Post requests are also supported.

Connection string to Mongodb instance mongodb://localhost:27017.
Target Framework is .netcoreapp 2.1 on win64.

To deploy download both the rar files and extract in a folder of choice there you will find " Mimirium.API.exe ", start it if error occurs make sure the port is not used.

Requests are as followed: 

Requests are listed here http://localhost:5000/api/company/home 

Get https://localhost:5000/api/company 
Returns all companies.

Get https://localhost:5000/api/company/id?id= {write id here}
Finds company with the given id and returns it.

Get https://localhost:5000/api/company/name?name= {write name here}
Finds company with the given name and returns it.

Put https://localhost:5000/api/company Sample body {"id":" ","name":" ","vat": }
Finds company based on the received company object id and updates the Name and Vat with the received company.

Post https://localhost:5000/api/company Sample body {"id":" ","name":" ","vat": }
Adds the received Company object to the database.

Scripts used for Postman requests:

pm.test("response is ok", function () {
    pm.response.to.have.status(200);
});
pm.test("response should be okay to process", function () { 
    pm.response.to.not.be.error; 
    pm.response.to.have.jsonBody(""); 
    pm.response.to.not.have.jsonBody("error"); 
});

