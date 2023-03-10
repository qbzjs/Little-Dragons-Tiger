using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable]
public struct CharacterStat
{
    [SerializeField] float hp;
    [SerializeField] float maxHp;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotSpeed;
    [SerializeField] float ap;
    [SerializeField] float attackDelay;
    [SerializeField] float attackRange;

    public UnityAction<float> changeHp;
    public float HP 
    { 
        get => hp;
        set
        {
            hp = Mathf.Clamp(value,0.0f, maxHp);
            changeHp?.Invoke(hp/maxHp);
        }
    }
    public float MoveSpeed
    {
        get => moveSpeed;
    }
    public float RotSpeed
    {
        get => rotSpeed;
    }
    public float AP
    {
        get => ap;
    }
    public float AttackDelay
    {
        get => attackDelay;
    }
    public float AttackRange
    {
        get => attackRange;
    }
}
