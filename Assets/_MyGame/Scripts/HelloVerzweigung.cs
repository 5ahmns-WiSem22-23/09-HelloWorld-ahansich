using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    bool wahr = true;
    bool falsch = false;
    int a = 2;
    int b = 3;
    int i = 5;

    void Start()
    {
        // Wenn wahr true ist UND falsch false ist, wird Debug.Log ausgeführt
        if (wahr == true && falsch == false)
        {
            Debug.Log("klappt");
        }

            // Wenn eins der beiden falsch ist, wird else ausgeführt
            else
            {
                Debug.Log("klapptNicht");
            }

        
        if(a == b)
        {
            Debug.Log("a ist b");
        }

            else if (a < b)
            {
                Debug.Log("a ist nicht gleich b");
            }


        if (a < b)
        {
            if(wahr==true && falsch==false)
            {
                Debug.Log("a ist kleiner und richtig");
            }
        }


        switch(i)
        {
            case 0: Debug.Log("case "+i); break;
            case 1: Debug.Log("case " + i); break;
            case 2: Debug.Log("case " + i); break;
            case 3: Debug.Log("case " + i); break;
            case 4: Debug.Log("case " + i); break;
            case 5: Debug.Log("case " + i); break;
        }

    }


}
