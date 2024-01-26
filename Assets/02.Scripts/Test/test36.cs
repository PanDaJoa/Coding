using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test36 : MonoBehaviour
{
    public string A;
    // Start is called before the first frame update
    void Start()
    {
        
        int sum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sum += int.Parse($"{A[i]}");
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
