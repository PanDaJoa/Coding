using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 2. 문자/문자열 형
        // 문자: char
        // 문자열: string

        char charValue1 = '전';
        char charValue2 = '1';
        char charValue3 = '+';
        string stringValue = "전민성";

        // 문자열을 다루는 방법
        // 2-1. 문자열 서식 string.format
        string str0 = "안녕 전민성";
        string myName = "김홍일";
        string str1 = string.Format("{0} {1}", "안녕", myName);
        //첫 번째 변수로 문자열 개수와 서식을 지정
        //두 번째 변수부터 문자열 데이터 전달

        int hour = 1;
        int minute = 15;

        Debug.Log(string.Format("{0}{1}", hour, minute)); //115
        Debug.Log(string.Format("{0}:{1}", hour, minute)); //1:15
        Debug.Log(string.Format("현재 시간: {0}:{1}", hour, minute)); //현재 시간: 1:15

        //정렬
        Debug.Log(string.Format("{0:-5}:{1}", hour, minute)); //1:15
        


        //정수 서식
        Debug.Log(string.Format("{0:D5}:{1}", hour, minute)); // 00001:15

        float fValue = 3.124532f;

        //소수점 서식
        Debug.Log(string.Format("소수점 1자리만 표 현: {0:F1}", fValue));


        // 2-2. 문자열 보간
        // $"텍스트(변수, 서식)텍스트"
        Debug.Log($"소수점 1자리만 표현: {fValue:F1}");

        // 2-3. 탐색

        // 2-4. 변형

        // 2-5. 분할
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
