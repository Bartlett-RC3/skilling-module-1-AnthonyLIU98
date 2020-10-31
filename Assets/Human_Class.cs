//LIBRARIES
using System;


//NAMESPACE-collection of object that can be reuse
namespace RC3_9_Humans
{
    public class Human_Class
    {
        //variables
        string name;
        float height;
        string countryOfOrigin;

        //constructor
        public Human_Class(string _name, float _height)
        {
            name = _name;
            height = _height;

        }
        //behaviours (functions)
        public string GetName()
        {
            return name;

        }

        public float GetHeight()
        {
            return height;
        }

        public SetCountryOfOrigin (string _countryOfOrigin)
        {
            countryOfOrigin = _countryOfOrigin;
        }

        private void Sleep()
        {
            //Actions
            //Brush the teech
            //Change into PJs
            //Make bed
        }

        public void Walking()
        {
            //Action here
        }

        public void WorkOur()
        {
            //Action here
        }

    }

 
   
}
