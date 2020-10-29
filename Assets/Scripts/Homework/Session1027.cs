using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1027 : MonoBehaviour
{
    // 1. VARIABLES - data taht is stored in your computer memory

    // Declaring Variables: Scope (visibility) -- Type -- Name -- Value (optional)

    // Numbers

    public int myFirstWholeNumber = 1;

    public int mySecondNumber = 2;
    
    public float myFirstDecimalNumber = 1.0f;

    public double myFirstLongDecimalNumber = 1.232323333333222d;

    // Text
    private string myFirstWords = "Hello World!!";
    public string mySecondWord = "Hello!";


    // Logical (binary can be either true or false)
    private bool myFirstBoolean = false;
    public bool mySecondBoolean = true;


    // 2. Data Structures

    // Declaring Data Structures: Scopes -- Type -- Name -- Values (optional)

    // Arrays
    public int[] myWholeNumberCollection = new int[5];
    public float[] myDecimalNumberCollection = { 1.0f, 2.0f, 3.0f };

    // Lists
    public List<int> myFirstIntList = new List<int>();

    // 3. Functions

    // Declaring Functions: // Scope -- Type -- Variables -- Body (Instructions)

    private int CalculatorSum (int _FirstNumber, int _SecondNumber)
    {
        int SumResult = _FirstNumber + _SecondNumber;
        return SumResult;
    }


    // Start is called before the first frame update
    void Start()
    {
        int SumResult = CalculatorSum(myFirstWholeNumber, mySecondNumber);
        Debug.Log("Adding two number reuslt is:" + SumResult.ToString());

        // Data in Arrays
        //Changinng the data
        myDecimalNumberCollection[0] = 2.8f;
        //Retriving the data
        float SumResult2 = CalculatorSum (myDecimalNumberCollection[0], myDecimalNumberCollection)

        //Data in Lists
        //Changing teh data
        myFirstIntList.Add(1);
        myFirstIntList.Add(9);
        myFirstIntList[0] = 5;
        myFirstIntList[2] = 12;

        //Retriving the data
        Debug.Log(myFirstIntList(0));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
