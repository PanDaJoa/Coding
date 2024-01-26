using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test19 : MonoBehaviour
{
    public int N;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= N; i++) 
        {
            string star = " ";

            for (int j = 1; j <= i; j++) 
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
