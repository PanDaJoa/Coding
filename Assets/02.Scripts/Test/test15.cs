using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test15 : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        for (int i = 1; i <= A; i++) 
        {
            if ( i % 3 != 0) 
            {
                a += i;
            }
        }
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
