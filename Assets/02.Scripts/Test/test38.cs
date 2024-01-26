using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test38 : MonoBehaviour
{
    public string A;
    // Start is called before the first frame update
    void Start()
    {
        for (char i = 'a' ; i <= 'z'; i++)
        {
            int B = A.IndexOf(i);
            Debug.Log(B);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
