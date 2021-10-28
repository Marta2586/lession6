namespace ArraysLession2
{
    private class ProgrammBase
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();

            Person artisPerson = new Person
            {
                Name = "Artis",
                Age = 48
            };
            persons.Add(artisPerson);
            persons.Add(artisPerson);
            persons.Add(artisPerson);

            persons.Remove(artisPerson);
    }
}