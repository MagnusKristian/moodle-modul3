namespace modul3api
{
    public class Person
    {
        public static Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string NoeAnnet { get; set; } = "x";
        


        public Person(string name, int age, string address, string gender)
        {
            Id = new Guid();
            Name = name;
            Age = age;
            Address = address;
            Gender = gender;

        }
        //public Person(){}
    }
}
