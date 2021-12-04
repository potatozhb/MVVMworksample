namespace Model
{
    using System;
    using System.ComponentModel;

    public class Users 
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private int age;
        public int Age {
            get { return age; }
            set
            {
                age = value;
            }
        }
        public string Job { get; set; }
        public bool Married { get; set; }

    }
}