using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char[][] inputArray = new char[][]
{
    new char[] { 'A', 'B', 'C', 'D', 'E' },
    new char[] { 'a', 'b', 'c', 'd', 'e' },
    new char[] { '0', '1', '2', '3', '4' },
    new char[] { 'F', 'G', 'H', 'I', 'J' },
    new char[] { 'f', 'g', 'h', 'i', 'j' }
};

        string result = ""; // "" = string.Empty;
        for (int i = 0; i < inputArray.Length; i++)
        {
            result += new string(inputArray[i]);
        }
        Debug.Log(result);
    }
}





