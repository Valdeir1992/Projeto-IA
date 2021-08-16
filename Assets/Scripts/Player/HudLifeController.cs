using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudLifeController : MonoBehaviour, IHudLife
{
    private IPlayerMediator _player;
    private float _currentLife;
    private Heart[] _hearts;
    [SerializeField] private Transform _slot;
    [SerializeField] private Heart _prefabHeart;

    public void Configure(IPlayerMediator player)
    {
        _player = player;

        _currentLife = player.GetLifeMax();

        _hearts = new Heart[Mathf.FloorToInt(_currentLife)];

        for (int i = 0; i < _currentLife; i++)
        {
            Heart heart = Instantiate(_prefabHeart, _slot);
            heart.HeartFull();
            _hearts[i] = heart;
        }
    }

    public void TakeDamage(float amount)
    { 
        _currentLife -= amount;

        for (int i = 0; i < _hearts.Length; i++)
        {
            if (i < _currentLife)
            {
                _hearts[i].HeartFull();
            }
            else
            {
                _hearts[i].HeartZero();
            }
        }

    }
}
