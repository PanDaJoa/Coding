using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test24 : MonoBehaviour
{
    public int[] N;
    public int X;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < N.Length; i++)
        {
            if (N[i] < X)
            {
                Debug.Log(N[i]);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
