using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {


	//Variables
	public int firstNumber = 1;
	public int secondNumber = 2;

	public string homeAddress = "MYHOMEADDRESS";
	public string postalCode = "V6T3K2";
	public int roomNumber = 801;
	public float gpsNumber = 203.133f;

	public int[] myFavouriateNumber = { 1, 3, 4 };
	public List<string> myHomeHistory = new List<string>();

    private int CalculatorMultiple(int _FirstNumber, int _SecondNumber)
    {
		int MultipleResult = _FirstNumber * _SecondNumber;
		return MultipleResult;
    }


	// Use this for initialization
	void Start ()
    {
		int MultipleResult = CalculatorMultiple(firstNumber, secondNumber);
		Debug.Log(MultipleResult);

		Dictionary<int, string> openWith = new Dictionary<int, string>();

		openWith.Add(1, "first page");
		openWith.Add(2, "second page");
		openWith.Add(3, "third page");
		openWith.Add(4, "forth page");


		Debug.Log(openWith[1]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
