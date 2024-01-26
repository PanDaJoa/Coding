using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test42 : MonoBehaviour
{
    public int[] Full;
    void Start()
    {
        int[] mal = { 1, 1, 2, 2, 2, 8 };
        int[] b = new int[6]; //빈 공간 6개를 넣을 수 있다.
        
        string result = string.Empty; // 빈 char배열과 같다
        for (int i = 0; i < Full.Length; i++)
        {
            b[i] = mal[i] - Full[i]; // 두배열을 뺐을 때 값이 b[i]

            result += b[i] + " ";
        }
        Debug.Log(result);




    }
}



