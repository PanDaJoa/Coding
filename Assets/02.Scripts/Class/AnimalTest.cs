using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat cat1 = new Cat("녹스", 3, "살색", "스핑크스", 6.1f, true);
        cat1.Speak();

        Cat cat2 = new Cat("제피르", 5, "흰색", "먼치킨", 5.6f, false);
        cat2.Speak();

        Dog dog1 = new Dog("찰리", 2, "검은색", "미니어처 핀셔", 3.5f, false);
        dog1.Speak();
        Dog dog2 = new Dog("루카스", 1, "갈색", "비글", 4.5f, true);
        dog2.Speak();

        // 고양이 행동
        cat1.Run();
        cat2.Run();
        cat1.Sleep();
        cat2.Sleep();
        cat1.Cry();
        cat2.Cry();
        cat1.Grooming(cat2);
        cat1.Grooming(dog1);

        // 강아지 행동
        dog1.Run();
        dog2.Run();
        dog1.Sleep();
        dog2.Sleep();
        dog1.Bark();
        dog2.Bark();
        dog1.Bite(dog2);
        dog2.Bite(cat2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
