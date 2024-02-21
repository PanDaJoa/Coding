using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IMoveable
{
    public void Move()
    {
        Debug.Log("몬스터가 움직입니다.");
    }
    public void Hit()
    {
        Debug.Log("몬스터가 공격 받았습니다.");
    }
}
