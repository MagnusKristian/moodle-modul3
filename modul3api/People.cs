namespace modul3api
{
    public class People
    {
        public List<Person> PeepsList { get; set; }

        public void MakePeople(Person person)
        {
            PeepsList.Add(person);
        }
    }
}
