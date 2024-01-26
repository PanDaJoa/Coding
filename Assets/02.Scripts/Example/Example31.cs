using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example31 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 배열 초기화
        int[] arr = new int[] { 1, 2, 3 };

        // 2차원 배열 초기화 (기존 1차원에서 {}를 한 번 더 잘 응용)
        int[,] arr2 = new int[,]
        {
            { 31, 28, 45 },
            { 10, 56, 68 }
        };
        Debug.Log(arr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
