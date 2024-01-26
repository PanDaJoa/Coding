using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log((A + B) % C);
        Debug.Log(((A % C) + (B % C)) % C);
        Debug.Log((A*B) % C);
        Debug.Log(((A % C) * (B % C)) % C);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
