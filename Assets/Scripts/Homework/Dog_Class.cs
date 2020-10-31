//librarys
using System;

//namesapce
namespace Dog
{
    //class
    public class Dog_Class
    {
        //variables
        string name;
        string hairColour;
        float height;


        //constructors
        public Dog_Class(string _name, string _hairColour)
        {
            name = _name;
            hairColour = _hairColour;
        }

        //behaviours(functions)
        public string GetName()
        {
            return name;
        }

        public string GetHairColor()
        {
            return hairColour;
        }

        public float GetHeight()
        {
            return height;
        }

        private void Play()
        {
            //Jumping
            //Crawling
            //TurningHead
        }

        private void Sleep()
        {
            //Action here
        }   
    }

}
