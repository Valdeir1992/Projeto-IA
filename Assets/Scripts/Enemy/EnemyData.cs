using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Prototipo/Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _motionSpeed;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _lifeMax;
    [SerializeField] private float _damage;

    public float MotionSpeed { get => _motionSpeed;}
    public float AttackSpeed { get => _attackSpeed;}
    public float LifeMax { get => _lifeMax;}
    public float Damage { get => _damage;}
}
