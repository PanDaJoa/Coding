using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDD : MonoBehaviour
{
    public int A;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 1)
            {
                Debug.Log(i);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
