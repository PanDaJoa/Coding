using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example26 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string firstName = "전";
        string lastName = "민성";
        string displayname = string.Empty; // 이름: 전민성

        // 문자열을 묶는 여러 가지 방법
        // 1. 더하기(+) 연산자 사용
        displayname = "이름:"+ firstName + lastName;
        Debug.Log(displayname);

        // 2. string.Format사용
        displayname = string.Format("이름:{0}{1}", firstName, lastName);
        Debug.Log(displayname);

        // 3. 문자열 보간법($) 사용
        displayname = $"이름 {firstName}{lastName}";
        Debug.Log(displayname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
