using MyPortfolio.Core.Entities;
using MyPortfolio.Core.Models;


namespace MyPortfolio.DataAccess.DataAccess
{
    public class Initializer
    {
        public Initializer()
        {
            Users = createUser();
            Companies = createCompanies();
            JobPositions = createJobPositions();
        }

        public List<User> Users = new List<User>();
        public List<Company> Companies = new List<Company>();
        public List<JobPosition> JobPositions = new List<JobPosition>();

        private List<User> createUser()
        {
            var users = new List<User>();

            users.Add(
                new User() { Id=1}
                );
            users.Add(
               new User() { Id=2}
               );
            users.Add(
               new User() { Id=3}
               );
            users.Add(
               new User() { Id=4}
               );

            return users;
        }
        private List<Company> createCompanies() 
        {
            var companies = new List<Company>();

            companies.Add(
                new Company() { Id = 1, Name = "Eldorado" }
                );
            companies.Add(
                new Company() { Id = 2, Name = "Detsky Mir" }
                );

            return companies;
        }
        private List<JobPosition> createJobPositions()
        {
            var jobPositions = new List<JobPosition>();

            jobPositions.Add(
                new JobPosition() { Id=1, Name="Architector", Description="Hui", Duration="2017-Present"}
                );
            jobPositions.Add(
                new JobPosition() { Id=2, Name="Tester", Description="Loh", Duration="2020-2023"}
                );

            return jobPositions;
        }

    }
}
