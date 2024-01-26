using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    
    void Start()
    {
        // UnityEngine.Random 클래스 난수 생성과 관련있는 클래스
        // 난수: 정의된 범위 내에서 무작위로 추출된 수 (=랜덤값)

        UnityEngine.Random.InitState(13);
        Debug.Log(UnityEngine.Random.Range(0, 100));
        //Debug.Log(UnityEngine.Random.Range(0f, 100f));
    }

    // Update is called once per frame

}
