using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test12 : MonoBehaviour
{
    public int H;
    public int M;
    public int AddM;
    // Start is called before the first frame update
    void Start()
    {
        int newH = H;  
        int newM = M + AddM;  

        if (newM >= 60)
        {
            newH += (newM / 60); // 60이면 1을 시간에 플러스 해줌
            newM = (newM % 60); // 0으로 만들어줌
        }
        if (newH >= 24) 
        {
            newH -= 24;  // -24를 하므로서 24를 넘거나 같을때 새벽시간으로 변경가능
        }
        Debug.Log($"{newH}:{newM}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
