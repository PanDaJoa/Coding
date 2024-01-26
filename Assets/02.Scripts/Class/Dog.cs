using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog
{
    public string Name;
    public int Age;
    public string Haircolor;
    public string Species;
    public float Weight;
    public bool Walk;

    public Dog(string name, int age, string haircolor, string species, float weight, bool walk)
    {
        Name = name;
        Age = age;
        Haircolor = haircolor;
        Species = species;
        Weight = weight;
        Walk = walk;
    }
    public Dog()
    {

    }
    public void Speak()
    {
        Debug.Log($"안녕. 내 이름은 {Name}이고 나이는 {Age} 살이고 털색깔은 {Haircolor}이고 종은 {Species}이고 몸무게는{Weight} 산책을 했니?{Walk}");
    }
    public void Run()
    {
        Debug.Log($"강아지 {Name}는 뛰고있다.");
    }
    public void Sleep ()
    {
        Debug.Log($"강아지 {Name}는 잠을 자고있다.");
    }
    public void Bark()
    {
        Debug.Log($"강아지 {Name}는 짖고있다.");
    }
    public void Bite(Dog otherdog)
    {

        Debug.Log($"강아지 {Name}는 강아지 {otherdog.Name}를 물어온다.");
    }
    public void Bite(Cat othercat)
    {
        Debug.Log($"강아지 {Name}는 고양이 {othercat.Name}를 물어온다.");
    }

}
