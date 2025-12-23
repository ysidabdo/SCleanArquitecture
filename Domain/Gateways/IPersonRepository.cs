using Domain.Entities;

public interface IPersonRepository
{
    Person GetPersonById(int id);
    void AddPerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(int id);
}