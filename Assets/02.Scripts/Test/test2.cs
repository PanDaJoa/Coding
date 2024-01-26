using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public int A;
    public int B;
    // Start is called before the first frame update
    void Start()
    {
        int A = 90;
        int B = 10;
        int C = 0;


        C = A;
        A = B;
        B = C; 

        Debug.Log(A);
        Debug.Log(B);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
