using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Student student1 = new Student("전민성", 30, 35.1f);
        student1.Speak();

        Student student2 = new Student("이성민", 24, 22.3f);
        student2.Name = "이성민";
        student2.Age = 24;
        student2.Speak();

        student1.Highfive(student2);

        // null: 사전적으로 존재하지 않는다, 비어있다.
        // 가장 빈번하게 오류를 일으키는 원인 중 하나
        Student student3 = null;
        // student3.Speak(); -> 버그

        // int/float/bool -> 값타입
        // class -> 참조 타입
        student3 = student2;
        student3.Name = "김예은";
        Debug.Log(student2.Name); // "이성민" vs "김예은" 김예은
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
