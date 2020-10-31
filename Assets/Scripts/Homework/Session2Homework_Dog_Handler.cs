using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dog;


public class Session2Homework_Dog_Handler : MonoBehaviour
{

    //Variables

    Dog_Class doggy1, doggy2, doggy3;
    VirtualDog_Class superdoggy1, superdoggy2, superdoggy3;


    // Start is called before the first frame update
    void Start()
    {
        doggy1 = new Dog_Class("Johnson", "Red");
        doggy2 = new Dog_Class("Jason", "Green");
        doggy3 = new Dog_Class("Tom", "Blue");
        superdoggy1 = new VirtualDog_Class("Johnsonx1", "Transparent Red");
        superdoggy2 = new VirtualDog_Class("Jasonx1", "Transparent Green");
        superdoggy3 = new VirtualDog_Class("Tomx1", "Transparent Blue");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(doggy1.GetName());
        Debug.Log(doggy2.GetHairColor());
        superdoggy1.Scan();
    }

    
}
