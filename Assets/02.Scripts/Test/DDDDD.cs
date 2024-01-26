using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDDD : MonoBehaviour
{
    void Start()
    {
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'A', 'B', 'C', 'D', 'D', 'D'},
            new char[] { 'a', 'f', 'z', 'z' },
            new char[] { '0', '9', '1', '2', '1' },
            new char[] { 'a', '8', 'E', 'W', 'g', '6' },
            new char[] { 'P', '5', 'h', '3', 'k', 'x' }
        };
        string a = string.Empty;
        int maxLength = 0;
        for (int i = 0; i < inputArray.Length; i++) // i 보다 inputArray.Length가 클때 실행
        {
            if (inputArray[i].Length > maxLength) // 만약 inputArray.Length가 maxLength보다 클 때
            {
                maxLength = inputArray[i].Length; // maxLength 는 nputArray[i].Length; 다
            }
        }

        for (int i = 0; i < maxLength; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (i < inputArray[j].Length)
                {
                    a += inputArray[j][i];
                }
            }
        }
        Debug.Log(a);
    }

}
