namespace FirstMauiApp.Model
{
    public class Human
    {


        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }

        public Human(string firstName, string secondName, DateTime birthDate)
        {
            FirstName = firstName;
            SecondName = secondName;
            BirthDate = birthDate;
        }
    }
}
