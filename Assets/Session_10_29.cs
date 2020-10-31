using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CLASS(es)


public class Session_10_29 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // If statement
        /*
        for( int i= 0; i<100; i++)
        {
            if (i%2 == 0)
            {
                Debug.Log("Whole Number:" + i);
            }
            else
            {
                Debug.Log("odd number" + i);
            }
        }
        */
        //Asking multiple questions
        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        //on
        if(question1Answer && question2Answer)
        {
            Debug.Log("Both question is true");
        }

        if(question1Answer || question2Answer)
        {
            Debug.Log("One of the answers is true");
        }
       






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
