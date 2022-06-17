namespace modul3api
{
    public class Student: Person
    {
        public bool IsStudent { get; set; }
        public List<string> Backpack { get; set; }

        public Student(bool isStudent, List<string> backpackcontent,string navn, int alder, string addresse, string kjønn) :base(navn, alder, addresse, kjønn)
        {
            IsStudent = isStudent;
            Backpack = backpackcontent;
        }
    }
}
