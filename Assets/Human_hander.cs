using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3_9_Humans;
using RC3_9_Cyborgs;

public class Human_hander : MonoBehaviour
{

    Human_Class yiguan, phil, yiguan2;


    // Start is called before the first frame update
    void Start()
    {
        yiguan = new Human_Class("Yiguan Liu", 1.74f);
        phil = new Human_Class("Phil", 1.75f);
        yiguan2 = new Cyborg("Cyyiguan", 1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(yiguan.GetName());
        yiguan.Walking();
        yiguan.WorkOur();
    }
}
