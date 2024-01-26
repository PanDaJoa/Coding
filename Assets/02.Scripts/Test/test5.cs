using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test5 : MonoBehaviour
{
    // 완

    // 형변환 사용
    public int height;
    public int weight;

    void Start()
    {

        int heightcm = 180;
        int weight = 64;


        float heightm = heightcm / 100; // (float)heightcm = heightcm 를 float로 형변환




        Debug.Log($"{weight / (heightm * heightm):F2}");



    }


    void Update()
    {

    }
}
