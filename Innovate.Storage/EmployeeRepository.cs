using System.Collections.Generic;
using System.Threading.Tasks;
using Innovate.Contracts;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Innovate.Storage
{
    public class EmployeeRepository
    {
        public async Task<List<Employee>> GetEmployeeDetailsByStatusAsync(Status status)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("local");
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Innovate");

            return await collection.Find(Builders<Employee>.Filter.Empty).ToListAsync();
        }
    }
}
