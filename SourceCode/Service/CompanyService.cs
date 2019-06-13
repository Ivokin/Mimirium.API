using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Mimirium.API.Models;
using Mimirium.API.Settings;

namespace Mimirium.API.Service
{
    public class CompanyService
    {
        private readonly IMongoCollection<Company> companies;

        public CompanyService(ICompanyDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            companies = database.GetCollection<Company>(settings.CompanyCollectionName);
        }

        public List<Company> Get()
        {
            return companies.Find(company => true).ToList();
        }

        public Company Get(string id)
        {
            return companies.Find<Company>(company => company.Id == id).FirstOrDefault();
        }

        public Company GetByName(string name)
        {
            return companies.Find<Company>(company => company.Name == name).FirstOrDefault();
        }

        public Company Create(Company company)
        {
            companies.InsertOne(company);
            return company;
        }

        public void Update(string id, Company companyIn)
        {
            companies.ReplaceOne(book => book.Id == id, companyIn);
        }
    }
}
