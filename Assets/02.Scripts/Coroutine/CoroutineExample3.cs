using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample3 : MonoBehaviour
{
    private Coroutine _teachCoroutine;
    private Coroutine _studyCoroutine;
    
    void Start()
    {
        _studyCoroutine = StartCoroutine(Study_Coroutine());
        _teachCoroutine = StartCoroutine(Teach_Coroutine());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // 이 스크립트에 속한 "모든" 코루틴을 중지시킨다.
            //StopAllCoroutines();
            // 매개변수로 전달한 "특정" 코루틴을 중지시킨다.
            StopCoroutine(_teachCoroutine); 
        }
        
    }

    private IEnumerator Study_Coroutine()
    {
        while (true)
        {
            yield return null; // 한프레임 쉰다.
            Debug.Log("공부 중...");
        }
    }

    private IEnumerator Teach_Coroutine()
    {
        while (true)
        {
            yield return null;
            Debug.Log("강의 중...");
        }
    }
}
