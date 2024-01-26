using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // 변수 이름은 의미있게
    // 표기법 : 퍼블릭 "파스칼케이스" 지역 ""
    [Header("이름")]
    public string Name = "시즈땡크";

    [Header("직업")]
    public string Job = "메카닉";

    [Header("길드")]
    public string Guild = "순애";
    
    [Header("레전드리 어빌리티")]
    public string Legendary_Mobility = "패시브 스킬 레벨이 1 증가";

    [Header("레전드리 어빌리티")]
    public string Legendary_Mobility2 = "보스 몬스터 공격 시 데미지 10% 증가";

    [Header("레전드리 어빌리티")]
    public string Legendary_Mobility3 = "상태 이상에 걸린 대상 공격 시 데미지 10% 증가";

   
    
    [Header("체력")]
    public int HP = 74884;

    [Header("마나")]
    public int MP = 37332;

    [Header("STR")]
    public int Strength = 8725;

    [Header("DEX")]
    public int Dexterity = 80570;

    [Header("INT")]
    public int Intelligence = 5838;

    [Header("LUK")]
    public int Luck = 6117;

    [Header("인기도")]
    public int popularity = 513;

    [Header("이동속도")]
    public int MoveSpeed = 140;

    
    
    [Header("공격력")]
    public float Damage = 107.00f;

    [Header("최종공격력")]
    public float FinalDamage = 52.90f;
    
    [Header("방어율무시")]
    public float IgnoringERA = 95.64f;

    [Header("크리 데미지")]
    public float CriticalDamage = 82.55f;
    
    [Header("보스 데미지")]
    public float BossDamage = 379.00f; 
        
 


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Name);
        Debug.Log(Job);
        Debug.Log(Guild);
        Debug.Log(Legendary_Mobility);
        Debug.Log(Legendary_Mobility2);
        Debug.Log(Legendary_Mobility3);
        Debug.Log(HP);
        Debug.Log(MP);
        Debug.Log(Strength);
        Debug.Log(Dexterity);
        Debug.Log(Intelligence);
        Debug.Log(Luck);
        Debug.Log(Damage);
        Debug.Log(FinalDamage);
        Debug.Log(IgnoringERA);
        Debug.Log(CriticalDamage);
        Debug.Log(BossDamage);
        Debug.Log(popularity);
        Debug.Log(MoveSpeed);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
