using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test13 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;
    // Start is called before the first frame update
    void Start()
    {
        int money = 0;
        if ((A == B) && (B == C) && (A == C)) // 모두 같을 때
        {
            money = 10000 + A * 1000;
        }
        else if (A == B || B == C || C == A) //셋중에 두개가 같을 때
        {
            if (A == B)
            {
                money = 1000 + A * 100;
            }
            if (B == C)
            {
                money = 1000 + A * 100;
            }
            if (A == C)
            {
                money = 1000 + A * 100;
            }
        }

        else
        {
            if (A > B && A > C) // A가장 클 때
            {
                money =  A * 100;
            }
            if (B > A && B > C) // B가장 클 때
            {
                money =  B * 100;
            }
            else                // C가장 클 때
            {
                money =  C * 100;
            }

        }
        Debug.Log(money);

    }     

        
        
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
