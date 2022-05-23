namespace organTransplant
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkingKidneys { get; set; }


        public Person(string name, int age, int workingKidneys)
        {
            Name = name;
            Age = age;
            WorkingKidneys = workingKidneys;
        }
    }
}