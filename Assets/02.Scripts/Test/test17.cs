using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test17 : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        int a = A;
        for (int i = 1; i <= 9; i++)
        {
           Debug.Log(A * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
