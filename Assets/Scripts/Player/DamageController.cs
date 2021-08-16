using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour, IDamage
{
    private IPlayerMediator _player;
    private float _currentLife;
    public void Configure(IPlayerMediator player)
    {
        _player = player;
        _currentLife = player.GetLifeMax();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float amount)
    {
        if(_currentLife - amount >= 0)
        {
            _currentLife -= amount;

            _player.ReceivedDamage(amount);
        }
        else
        {
            _currentLife = 0;
            _player.ReceivedDamage(_player.GetLifeMax());
            _player.Died();
        }
    }
}
