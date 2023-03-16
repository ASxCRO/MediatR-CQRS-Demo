using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel
            {
                Id = 1,
                FirstName = "Antonio",
                lastName = "Supan"
            });

            people.Add(new PersonModel
            {
                Id = 2,
                FirstName = "Sue",
                lastName = "Storm"
            });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel Insert(string firstName, string lastName)
        {
            PersonModel model = new PersonModel
            {
                FirstName = firstName,
                lastName = lastName,
            };

            model.Id = people.Max(x => x.Id) + 1;
            people.Add(model);

            return model;
        }
    }
}
