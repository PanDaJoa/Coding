using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test18 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        for (int i = 1; i <= 9; i++) 
        {
            for (int I = 2; I <= 9; I++) 
            {
                a = I * i;
                Debug.Log($"{I} *{i} = {a}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
