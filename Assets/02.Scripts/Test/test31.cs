using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test31 : MonoBehaviour
{
    public string S;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        char a = S[i - 1];
        Debug.Log(char.ToUpper(a));     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
