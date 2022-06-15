using System;

namespace BasicClasses
{
    class Forest
    {
        public int age;
        public int Age
        {
            get { return age;}
            set {if (value < 0) { age = 0;} else if (value > 120) {age = 0;} else {age = value;} }
        }





        public int Age1 { get; set; }









        public string biome;

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }


            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }
    }

}