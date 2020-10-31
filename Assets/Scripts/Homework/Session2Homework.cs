using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2Homework : MonoBehaviour
{
    string[] fruits = { "apple", "grape", "pear" };


    //function with a condition

    private void WhichOneIsBigger(int _FirstNumber, int _SecondNumber)
    {
        if (_FirstNumber > _SecondNumber)
        {
            Debug.Log(_FirstNumber);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        //Loops
        //For loop(counter, end condition, step)

        for (int counter = 0; counter < fruits.Length; counter = counter+1) 
        {
            Debug.Log("The current fruits at position" + " " + counter + " is" + " " + fruits[counter]);
        }

        //foreach

        foreach (string currentFruit in fruits)
        {
            Debug.Log("Going over the basket with " + currentFruit);
        }

        //WhileLoop (needs a condition to end)

        int whileCounter = 0;
        string basket = "Fruits in the basket are ";
        while (whileCounter < fruits.Length)
        {
            basket += fruits[whileCounter] + ",";
            whileCounter++;
        }
        Debug.Log(basket);

       
        //Conditionals (asking teh computer question)


    }

   
       


    // Update is called once per frame
    void Update()
    {
        
    }
}
