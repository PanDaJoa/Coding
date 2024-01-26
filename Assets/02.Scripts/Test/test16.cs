using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test16 : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        for (int i = 1; i <= A; i++)
        {
            a *= i;

        }
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
