using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example33 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 정수형 가변 배열 초기화 방식
        int[][] numbers = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 10, 20, 30, 40 },
            new int[] { 100, 200, 300, 400, 500 }
        };

        // 배열 안에 배열에 있는 구조다.
        // 1차원(가로)의 크기 조회.
        Debug.Log(numbers.Length);  // 3 -> 2차원(세로)의 크기를 알 수 있구나.
        Debug.Log(numbers[0].Length); // 3
        Debug.Log(numbers[1].Length); // 4
        Debug.Log(numbers[2].Length); // 5

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Debug.Log(numbers[i][j]);
            }
        }
        // Q. 위 가변 배열의 모든 아이템을 출력해보세요.

    }

    // Update is called once per frame
    void Update()
    {

    }
}