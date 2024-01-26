using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test26 : MonoBehaviour
{
    public int[] A;
    // Start is called before the first frame update
    void Start()
    {
        float a = 0; //누적(배열들 합계)
        
        for (int i = 0; i < A.Length; i++) 
        {
            a += A[i];   // a에 더한 후 대입
        }
        float average = a / A.Length;
        Debug.Log(average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
