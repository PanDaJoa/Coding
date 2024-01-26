using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour
{
    public int A;
    public int B;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(A * (B % 10));
        Debug.Log(A * (B / 10 % 10));
        Debug.Log(A * (B / 100));
        Debug.Log(A * B);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
