using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class test44 : MonoBehaviour
{
    public string A;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < A.Length / 2; i++)
        {
            if (A[i] != A[A.Length - i - 1])
            {
                Debug.Log(0); // 팰린드롬이 아님.
                return;
            }
        }
        Debug.Log(1); // 팰린드롬임.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
