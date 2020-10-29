// LIBRARIES
using System;

// NAMESPACE
namespace RC3_9
{
    // CLASS
    public class Human_Class
    {
        // VARIABLES
        string name;
        float height;
        string countryOfOrigin;

        // CONSTRUCTOR
        public Human_Class(string _name, float _height)
        {
            name = _name;
            height = _height;
            SetClothing();
        }

        // BEHAVIOURS (Functions)
        public string GetName()
        {
            return name;
        }

        public float GetHeight()
        {
            return height;
        }

        public void SetCountryOfOrigin(string _countryOfOrigin)
        {
            countryOfOrigin = _countryOfOrigin;
        }

        private void Sleep()
        {
            // Actions
            // Brush the teeth
            // Change into PJs
            // Make bed
        }

        public void Walking()
        {
            // Action here
        }

        public void WorkOut()
        {
            // Actions here
        }

        private void SetClothing()
        {
            // Set some cloths for the human
        }
    }
}
