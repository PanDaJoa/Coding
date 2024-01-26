using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test25 : MonoBehaviour
{
    public int[] A; // 입력

    void Start()
    {
        int min = A[0]; // 최소 배열의 값
        int max = A[0]; // 최대 배열의 값

        for (int i = 0; i < A.Length; i++) // 배열 0부터 시작; 개수 찾기; 증가
        {
            if (A[i] < min) // 배열의 값이 min 보다 작다면
            {
                min = A[i]; // min
            }
            else if (A[i] > max) // 배열이 값이 max 보다 크다면
            {
                max = A[i]; // max
            }
        }
        Debug.Log(min); // 최솟값
        Debug.Log(max); // 최댓값
    }


    void Update()
    {

    }
}
