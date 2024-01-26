public class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteColour { get; set; }
    public int Age { get; set; }
    public bool IsWorking { get; set; }
}

public static class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 25, IsWorking = true },
            new Person { PersonId = 2, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "White", Age = 35, IsWorking = true },
            new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true },
            new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true }
        };

        string relationshipGinaMary = "Sisterhood";
        string relationshipIanMike = "Brotherhood";

        double averageAge = people.Average(p => p.Age);
        Person youngestPerson = people.OrderBy(p => p.Age).First();
        Person oldestPerson = people.OrderByDescending(p => p.Age).First();

        Console.WriteLine($"2: {people[0].FirstName} {people[0].LastName}'s favorite colour is {people[0].FavoriteColour}");
        Console.WriteLine($"PersonId: {people[2].PersonId}");
        Console.WriteLine($"FirstName: {people[2].FirstName}");
        Console.WriteLine($"LastName: {people[2].LastName}");
        Console.WriteLine($"FavoriteColour: {people[2].FavoriteColour}");
        Console.WriteLine($"Age: {people[2].Age}");
        Console.WriteLine($"IsWorking: {people[2].IsWorking}");
        Console.WriteLine($"1: {people[1].FirstName} {people[1].LastName}'s favorite colour is: {people[1].FavoriteColour}");
        Console.WriteLine($"{people[3].FirstName} {people[3].LastName}'s Age in 10 years is: {people[3].Age + 10}");
        Console.WriteLine($"THe relationship between {people[0].FirstName} and {people[3].FirstName} is: {relationshipGinaMary}");
        Console.WriteLine($"The relationship between {people[1].FirstName} and {people[2].FirstName} is: {relationshipIanMike}");
        Console.WriteLine($"average age is: {averageAge}");
        Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
        Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");
        Console.WriteLine($"PersonId: {people[2].PersonId}");
        Console.WriteLine($"firstName: {people[2].FirstName}");
        Console.WriteLine($"lastName: {people[2].LastName}");
        Console.WriteLine($"FavoriteColour: {people[2].FavoriteColour}");
        Console.WriteLine($"Age: {people[2].Age}");
        Console.WriteLine($"isWorking: {people[2].IsWorking}");
        Console.WriteLine($"PersonId: {people[3].PersonId}");
        Console.WriteLine($"FirstName: {people[3].FirstName}");
        Console.WriteLine($"LastName: {people[3].LastName}");
        Console.WriteLine($"FavoriteColour: {people[3].FavoriteColour}");
        Console.WriteLine($"Age: {people[3].Age}");
        Console.WriteLine($"IsWorking: {people[3].IsWorking}");
        Console.WriteLine($"personID: {people[2].PersonId}");
        Console.WriteLine($"Firstname:{people[2].FirstName}");
        Console.WriteLine($"lastname: {people[2].LastName}");
        Console.WriteLine($"FavaoriteColor: {people[2].FavoriteColour}");
        Console.WriteLine($"Age: {people[2].Age}");
        Console.WriteLine($"Isworking:{people[2].IsWorking}");
    }
}