using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 100; i++) 
        {
            print(i);
        }
        int odd = 1;
        while (odd <= 100)
        {
            print(odd);
            odd = odd + 2;
        }
        float x = 1.0f;
        float r = circle(x);
        
        
    
    }
     float circle(float x)
    {
        float result;
        x = 5.0f;
        result = 3.14f * (x*x) ;
        print(result);
        return result;
    }
}
