public class PersonBuilder
{
    private Person _person;
    public PersonBuilder()
    {
        _person = new Person();
    }
    public PersonBuilder Id(int id)
    {
        this._person.Id = id;
        return this;
    }
    public PersonBuilder Name(string name)
    {
        this._person.Name = name;
        return this;
    }
    public PersonBuilder Family(string family)
    {
        this._person.Family = family;
        return this;
    }
    public PersonBuilder Age(int age)
    {
        this._person.Age = age;
        return this;
    }
    public Person Build()
    {
        return _person;
    } 
}