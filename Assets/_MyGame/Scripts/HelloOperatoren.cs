using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HelloOperatoren : MonoBehaviour
{
    bool wahr = true;
    bool falsch = false;

    private void Start()
    {
        int i = 0;
        Debug.Log(i);

        i++; // Add one
        Debug.Log(i);

        // Add two
        i += 2;
        Debug.Log(i);

        // Multiply by two
        i += i;
        Debug.Log(i);

        Debug.Log(3 + 2);

        Debug.Log(3 - 2);

        Debug.Log(3 * 3);

        Debug.Log(12 / 4);

        if(wahr==true & falsch==false)
        {
            Debug.Log("klapptLogisch");
        }

        if (wahr == true && falsch == false)
        {
            Debug.Log("klapptLogisch2");
        }

        if (wahr == true | falsch == false)
        {
            Debug.Log("klapptLogisch3");
        }
    }
}