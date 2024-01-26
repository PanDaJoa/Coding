using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test9 : MonoBehaviour
{
    public int year;
    // Start is called before the first frame update
    void Start()
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log(1);
        }
        else
        {
            Debug.Log(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
