using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class test33 : MonoBehaviour
{
    public string InputString;
    void Start()
    {
        
        int result = 0; 

        for (int i = 0; i < InputString.Length; i++) // i가 0일때 InputString을 1씩 늘려서 반복
        {
            if (InputString[i] == ' ') //만약 InputString가 ' '공백 일 때  
            {
                result++; //공백 카운트 1씩 더한다
            }
        }
        Debug.Log(result + 1); // result에다가 +1을 한다
    }

    // Update is called once per frame
    void Update()
    {

    }
}
