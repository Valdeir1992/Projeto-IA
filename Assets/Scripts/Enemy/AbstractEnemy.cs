using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{
    private float _currentLife;

    [SerializeField] private EnemyData _data;

    public EnemyData Data { get => _data; }

    private void Awake()
    {
        _currentLife = _data.LifeMax;
    }

    public abstract void Move(Vector3 direction);

    public abstract bool Attack();

    public void TakeDamage(float amount)
    {
        if(_currentLife - amount > 0)
        {
            _currentLife=- amount;
        }
        else
        {
            _currentLife = 0;

            Dead();
        }
    }

    public abstract void Dead();
}
