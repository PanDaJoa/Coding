using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. 숫자형
        // 1-1. 실수형: 소수점이 있는 숫자
        // folat, double, decimal
        // 
        float floatValue = 3.14159265358979f;     // 7자리 정밀도
        double doubleValue = 3.14159265358979;   // 15자리 정밀도
        decimal decimalValue = 3.14159265358979m; // 29자리 정밀도

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
