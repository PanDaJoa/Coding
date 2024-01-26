using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test8 : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
        if (score >= 90 && score <= 100) 
        {
            Debug.Log("A");
        }
        else if (score >= 80 && score <= 89)
        {
            Debug.Log("B");
        }
        else if (score >= 70 && score <= 79)
        {
            Debug.Log("C");
        }
        else if (score >= 60 && score <= 69)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
