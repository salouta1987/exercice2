using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Star()
    {
        sum(5, 2);
        prod(5, 2);
        div(5, 0);
    }
        
    public void sum(float a,float b)
    {
        Debug.Log(a + b);
    }
    public void prod(float a,float b)
    {
       
        Debug.Log(a * b);
    }
    public void div(float a,float b)
    {
        if (b == 0)
        {
            Debug.Log("error : b=0");
        }
        else
        {
            Debug.Log(a / b);
        }
    }
}
