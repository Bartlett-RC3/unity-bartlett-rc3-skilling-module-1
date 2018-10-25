

namespace OctaviansWorld {
    // Refrences

    // Class Definition
    // Scope -- Type -- Name
    public class Human
    {
        // Variables
        int age;
        float height;
        bool generder;
        string firstName, familyName;
        bool hungry;
        float energy;

        // Constructor 
        public Human(int _age, float _height, bool _gender, string _firstName, string _familyName)
        {
            age = _age;
            height = _height;
            generder = _gender;
            firstName = _firstName;
            familyName = _familyName;
            hungry = true;
            energy = 100;
        }

        // Functions (Methods)
        public void DayInLife()
        {
            Ageing();
            Eating();
            Sleeping();
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        private void Ageing()
        {
            age = age + 1;
            energy = energy - 1;
        }

        public void Eating()
        {
            hungry = false;
            energy = energy - 1;
        }

        private void Sleeping()
        {
            hungry = true;
            energy = energy + 1;
        }


    }

}
