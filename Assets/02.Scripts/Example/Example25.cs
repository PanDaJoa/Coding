using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{
    public int[] N;
    

  
   
    // Start is called before the first frame update
    void Start()
    {
        // Length 속성: 배열의 길이
        //Debug.Log(N.Length);

        int count = N.Length;
        for(int i = 0; i < 3; i++)
        {
            Debug.Log(N[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
