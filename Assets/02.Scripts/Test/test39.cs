using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test39 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] inputArray = new int[9, 9]
        {
            { 3, 23, 85, 34, 17, 74, 25, 52, 65 },
            { 10, 7, 39, 42, 88, 52, 14, 72, 63 },
            { 87, 42, 18, 78, 53, 45, 18, 84, 53 },
            { 34, 28, 64, 85, 12, 16, 75, 36, 55 },
            { 21, 77, 45, 35, 28, 75, 90, 76, 1 },
            { 25, 87, 65, 15, 28, 11, 37, 28, 74 },
            { 65, 27, 75, 41, 7, 89, 78, 64, 39 },
            { 47, 47, 70, 45, 23, 65, 3, 41, 44 },
            { 87, 13, 82, 38, 31, 12, 29, 29, 80 }
        };
        int max = 0; //최대값
        int a = 0;
        int b = 0;
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                if (max > inputArray[x,y])
                {
                    continue;
                }
                max = inputArray[x, y];
                a = y;
                b = x;
            }
        }
        Debug.Log(max);
        Debug.Log($"{a + 1} {b + 1}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
