namespace FirstMauiApp.Model
{
    public class Human
    {
        private string firstName;
        private string secondName;
        private DateTime birthDate;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }

        public Human(String _firstName, String _secondName, DateTime _birthDate)
        {
            firstName = _firstName;
            secondName = _secondName;
            birthDate = _birthDate;
        }
    }
}
