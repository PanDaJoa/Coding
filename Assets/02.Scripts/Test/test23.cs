using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test23 : MonoBehaviour
{
    // 개수 세기
    // 정수가 담긴 배열 N이 주어졌을 때, 정수 v가 몇 개인지 구하는 프로그램을 작성하시오.

    public int[] N; // 배열
    public int v;


    private void Start()
    {
        int count = 0; // 누적 

        for (int i = 0; i < N.Length; i++) // 배열은 0부터 시작; 배열의 개수; 증가
        {
            if (N[i] == v) // 배열에 있는 숫자가 v랑 같다면
            {
                count++; // count에 추가
            }
        }
        Debug.Log(count);

    }
}


