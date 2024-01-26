using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test37 : MonoBehaviour
{
    public string S;
    // Start is called before the first frame update
    void Start()
    {
        string result = string.Empty;
        for (int i = S.Length - 1; i >= 0; i--)
        {
            result += S[i];
        }
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
