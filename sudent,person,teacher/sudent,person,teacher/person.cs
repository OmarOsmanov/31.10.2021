namespace Task1
{
    public class Person
    {
        private int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }
        public void Greet() { }

        public void SetAge(int age)
        {
            if (age > 0)
            {
                Age = age;
            }
        }

        public int GetAge()
        {
            return Age;
        }

    }
}