using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ExceptionTest : MonoBehaviour
{
    // 예외란: 프로그램이 실행되는 동안 발생되는 오류를 의미 (런타임 에러)
    // -> 테스트를 진행하면서 잡을 수 있다.

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        bool result = TryGetComponent<Rigidbody2D>(out _rigidbody2D);
        if (result)
        {
            _rigidbody2D.position = Vector2.zero;
        }
        else
        {
            Debug.Log(message: "게임 오브젝트에 rigidbody2D 컴포넌트가 안달려있습니다.");
        }
        
    }

    private void Start()
    {
        // 1. NullReferenceException
        // 이 예외는 참조된 객체가 Null인데 이 객체의 멤버(변수, 함수)에 접근할 때 발생
        GameObject player = GameObject.Find("player");
        if (player != null )
        {
            player.GetComponent<Rigidbody2D>();
        }
        
        // 2. IndexOutofRangeException
        // 배열이나 리스트에서 유효하지 않은 인덱스에 접근할 때 발생
        int[] numbers = new int[5] { 10, 20, 30, 40, 50 }; // Index: 0 ~ 4
        int index = 7;
        // 해결: 유효 범휘 검사를 하자
        if(0 <= index && index < numbers.Length)
        {
            Debug.Log(numbers[index]);
        }
        Debug.Log(numbers[index]);

        // 3. MissingReferenceException
        // 유니티에서 할당되지 않은 객체의 멤버에 접근하거나
        // 씬에서 삭제(destroy)되었지만 여전히 그 객체를 창조하려고 할 때 발생
        // 비화설화된 게임 오브젝트에서 코루틴을 실행하려고 할 때도 발생
        
        // 해결: 1. 인스펙터 확인을 잘 하자
        // 해결: 2. null 검사를 하자

        GameObject monsterobject = GameObject.Find("Monster");
        DestroyImmediate(monsterobject);
        if(monsterobject != null ) 
        {
            Debug.Log(monsterobject);
        }
         monsterobject.transform.position = Vector2.zero;

        // 4. DivdeByZeroException
        // 정수 타입의 숫자를 0으로 나누려고 할 때 발생
        int health = 0;
        int maxHealth = 100;
        // 해결: 0검사를 잘하자
        if(health == 0)
        {
            Debug.Log(message:0);
        }
        else
        {
            Debug.Log(message:maxHealth / health);
        }


        // 5. FormatException
        // 문자열을 형변환 하려고 할 때 데이터의 타입이 원하는 데이터 타입과 일치하지 않을 때

        string numberString = "O"; // 대문자 O

        // 해결: try 계열 메서드(함수)를 사용하자

        //int number = int.Parse(numberString);
        //Debug.Log(number);

        int number = 0;
        bool result = int.TryParse(numberString, out number);
        if(result)
        {
            Debug.Log(number);
        }
        else
        {
            Debug.Log(message: "형변환 실패!");
        }


    }

 
}
