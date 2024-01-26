using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test10 : MonoBehaviour
{
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        if (x > 0 && y > 0)
        {
            Debug.Log(1);
        }
        else if (x < 0 && y > 0)
        {
            Debug.Log(2);
        }
        else if (x < 0 && y < 0)
        {
            Debug.Log(3);
        }
        else
        {
            Debug.Log(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
