using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example36 : MonoBehaviour
{
    public int A;
    void Hello()
    {
        return; // 반환 데이터가 없는 함수의 경우 return만 호출해서
                // 함수 중간에 종료 용도로 사용 가능하다.
        Debug.Log("Hello");


    }
    
    // Q. 매개변수로 정수를 하나 입력 받아서 홀수이면 true 짝수이면 false를 반환하는 함수
    // 함수명: IsOdd
    bool IsOdd(int num)
    {

        if (num % 2 == 1) //홀수 일 때 공식           (num % 2 == 0) 짝수 일 때 공식
        {
            return true;
        }
        else 
        {
            return false;
        }


    }
    // 함수 만들 때 4가지 경우의 수
    // 1. 반환 데이터가 있고, 매개 변수도 있는 함수       // int Sum(int, int)
    // 2. 반환 데이터가 없고(void), 매개 변수 있는 함수   // void Test (int)
    // 3. 반환 데이터가 있고, 매개 변수 없는 함수         // int GetLength()
    // 4. 반환 데이터가 없고(void), 매개 변수 없는 함수   // void Hello()    
    void Start()
    {
        // 3
        // Debug.Log(뭐시기) -> false
        Debug. Log(IsOdd(A));
        for (int i = 1; i < 100; i++)
        {
            // 만약(홀수냐(i)? ==  true)
            if (IsOdd(i) == true)
            {
                Debug.Log(i);
            }
            
        }
        
    }

    
    void Update()
    {

    }
}
