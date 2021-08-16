using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Heart : MonoBehaviour
{
    private float _value;
    [SerializeField] private Image _fill;

    public float Value { get => _value; }
    public void HeartFull()
    {
        _fill.fillAmount = 1;
        _value = 1;
    }

    public void HeartHalf()
    {
        _fill.fillAmount = 0.5f;
        _value = 0.5f;
    }

    public void HeartZero()
    {
        _fill.fillAmount = 0;
        _value = 0;
    }
}
