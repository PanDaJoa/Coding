using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35_1 : MonoBehaviour
{
    /**
       // 반환 자료형이 없을 경우: void
       '반환 자료형' '함수 이름'('매개변수 목록')
     {
      // 실행할 코드들
      // return 반환 데이터
     } 
   **/
    // 1. 매개변수란: 함수를 호출(실행)할 때 전달되는 값
    // 2. return이란:
    //    -return이 호출되면 함수를 종료
    //    -프로그램의 흐름을 호출자에 돌려준다.
    //    -이때 특정 반환 자료형의 데이터를 반환한다.
    // Sum이라는 함수는 매개 변수 두개를  받아서 뭔가 처리후 int 자료형의 데이터를 돌려주는 함수다.    
    int Plus(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    // 위에서 return을 호출해 함수를 종료했으므로 아래 코드는 실행되지 않는다.
    int Sub(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }

    int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }

    int Divide(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }

    void Start()
    {
        // 더하기
        int result = Plus(3, 5);
        Debug.Log(result);

        // 빼기
        result = Sub(17, 9);
        Debug.Log(result);

        // 곱하기
        result = Multiply(22, 55);
        Debug.Log(result);

        // 나누기
        result = Divide(30, 6);
        Debug.Log(result);
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
