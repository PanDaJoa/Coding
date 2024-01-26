using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test35 : MonoBehaviour
{
    public string[] A;
    void Start()
    {

        for (int i = 0; i < A.Length; i++)
        {
            Debug.Log($"{A[i][0]}{A[i][A[i].Length - 1]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
