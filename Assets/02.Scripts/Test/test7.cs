using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
{
    public int A = 3; // 확인 위해 public 사용함
    public int B = 1;
    public int C = 2;

    // 오름차순

    void Start()
    {
        // if : 만약 ~라면? ~한다.
        // else if : 그렇지 않고 ~라면? ~한다.
        // else : 이도저도 아니라면? ~한다.

        if (A < B)  // B가 A보다 큰 경우
        {
            if (B < C) // C가 B보다 크다면
            {
                Debug.Log($"{A},{B},{C}");  // ACB 출력

            }
            else if (C < A)  // 그렇지 않고 A가 C보다 크다면
            {
                Debug.Log($"{C},{A},{B}");  // CAB 출력
            }

            else     // 이도저도 아니라면
            {
                Debug.Log($"{A},{C},{B}");  // ABC 출력
            }



        }
        else if (B < A)// 이도저도 아닐 경우
        {
            if (A < C)
            {
                Debug.Log($"{B},{A},{C}");
            }
            else if (C < B)
            {
                Debug.Log($"{C},{B},{A}");
            }
            else if (C < A)
            {
                Debug.Log($"{B},{C},{A}");
            }

        }
    }
    void Update()
    {

    }
}
