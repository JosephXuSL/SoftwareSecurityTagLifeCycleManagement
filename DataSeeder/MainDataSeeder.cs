using SSTLifeCycleManagement.DbContexts;
using SSTLifeCycleManagement.Entities;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SSTLifeCycleManagement.DataSeeder
{
    public class MainDataSeeder
    {
        private readonly MainDbContext _dbContext;
        private readonly IWebHostEnvironment _env;

        public MainDataSeeder(MainDbContext dbContext, IWebHostEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }   

        public void Seed()
        {
            _dbContext.Database.EnsureCreated();
            if (!_dbContext.Countries.Any())
            {
                var path = Path.Combine(_env.ContentRootPath,"DataSeeder/JsonData/Countries.json");
                var json =File.ReadAllText(path);
                var countries = JsonSerializer.Deserialize<IEnumerable<Country>>(json);

                _dbContext.Countries.AddRange(countries);               
            }
            if (!_dbContext.People.Any())
            {
                var path = Path.Combine(_env.ContentRootPath, "DataSeeder/JsonData/People.json");
                var json = File.ReadAllText(path);
                var people = JsonSerializer.Deserialize<IEnumerable<People>>(json);
                people.ToList().ForEach(p => p.Country = _dbContext.Countries.First(c => c.CountryCode == p.CountryCd));
                _dbContext.People.AddRange(people);               
            }
            _dbContext.SaveChanges();
        }
    }
}
