using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour, IAnimator
{
    private IPlayerMediator _player;
    private Animator _anim;
    public void Configure(IPlayerMediator player)
    {
        _player = player;
        _anim = GetComponent<Animator>();
    }

    public void Dead()
    {
        _anim.Play("Dead");
    }

    public void Idle()
    {
        _anim.Play("Idle");
    }

    public void Walk()
    {
        _anim.Play("Walk");
    }
}
