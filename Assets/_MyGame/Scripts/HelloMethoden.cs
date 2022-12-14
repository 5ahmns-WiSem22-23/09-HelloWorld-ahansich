using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    private int startValue = 0;

    //3) Der Wert, der dazugezählt wird, ist bei der Deklaration noch nicht bekannt
    //z.B. Random oder User Input
    private int startValue3 = 0;

    //4) Copy by value
    private int startValue4 = 0;

    //5) Return
    private int startValue5 = 0;


    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden");

        //at 2)
        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        //at 3)
        Debug.Log("before startValue3: " + startValue);
        IncrementBy(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue);

        //at 4)
        Debug.Log("before startValue4: " + startValue4);
        OutDecrementedValue(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        //at 5)
        Debug.Log("before startValue5: " + startValue5);
        startValue5 = GetDiffernce(startValue5, 2);
        Debug.Log("after  startValue5: " + startValue5);
    }

    //5) incl. return value
    private int GetDiffernce(int a, int b)
    {
        return a - b;
    }

    //4)
    private void OutDecrementedValue(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    //3)
    private void IncrementBy(int valToAdd)
    {
        startValue3 += Mathf.Abs(valToAdd);
    }

    //2)
    private void IncrementByOne()
    {
        startValue++;
    }
}