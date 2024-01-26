using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test27 : MonoBehaviour
{
    public int[] A; // 입력

    void Start()
    {
        // 가장 큰 값을 저장할 변수(기본값은 0)
        int maxNumber = 0;
        int maxIndex = 0;
        for (int i = 0; i < A.Length; i++) // 배열 0부터 시작; 개수 찾기; 증가
        {
            // 1. 현재 위치에 있는 배열 값을 가져온다.
            int number = A[i];

            // 2. 현재 값이 MaxNumber보다 크면 교체
            if (number > maxNumber)
            {
                // 가장 큰 값 교체
                maxNumber = number;
                // 가장 큰 값이 있는 위치도 교체
                maxIndex = i;
            }
        }
        Debug.Log(maxNumber);
        Debug.Log(maxIndex + 1);

    }


    void Update()
    {

    }
}
