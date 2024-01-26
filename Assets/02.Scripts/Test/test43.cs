using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test43 : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 1; i <= A; i++)
        {
            string star = " ";

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                star += "*";
            }
            Debug.Log(star);
        }
        for (int i = A - 1; i > 0; i--)
        {
            string star = " ";

            for (int j = 0; j <= 2 * i - 2; j++)
            {
                star += "*";
            }
            Debug.Log(star);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
