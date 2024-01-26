using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat
{
    public string Name;
    public int Age;
    public string Haircolor;
    public string Species;
    public float Weight;
    public bool Water;

    public Cat(string name, int age, string haircolor, string species, float weight, bool water)
    {
        Name = name;
        Age = age;
        Haircolor = haircolor;
        Species = species;
        Weight = weight;
        Water = water;
    }
    public Cat()
    {

    }
    public void Speak()
    {
        Debug.Log($"안녕. 내 이름은 {Name}이고 나이는 {Age} 살이고 털색깔은 {Haircolor}이고 종은 {Species}이고 몸무게는{Weight} 나는 물을좋아할까?{Water}");
    }
    public void Run()
    {
        Debug.Log($"고양이 {Name}는 뛰고있다.");
    }
    public void Sleep()
    {
        Debug.Log($"고양이 {Name}는 잠을 자고있다.");
    }
    public void Cry()
    {
        Debug.Log($"고양이  {Name}는 울고있다.");
    }
    public void Grooming(Cat othercat)
    {
        
        Debug.Log($"고양이 {Name}는 고양이 {othercat.Name}와 그루밍을 하고있다.");
    }
    public void Grooming(Dog otherdog)
    {
        Debug.Log($"고양이 {Name}는 강아지 {otherdog.Name}와 그루밍을 하고있다.");
    }


}  


