using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class test29 : MonoBehaviour
{
    public int[] A;
    // Start is called before the first frame update
    void Start()
    {
        int[] B = new int [A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            B[i] = A[i];
        }

        // 2. 배열 B의 각 요소의 값을 B로 복사한다.
        // B[5] -> A[0]
        // B[4] -> A[1]
        //...
        // B[0] -> A[5] <-- A[A.Length - i - 1] = B[i]
        for (int i = 0;i < A.Length; i++)
        {
            A[A.Length - i - 1] = B[i];
        }

        // 3. 배열 A의 각 요소 값을 출력한다.
        foreach (int num in A)
        {
            Debug.Log(num);
        }
    }
}
    
