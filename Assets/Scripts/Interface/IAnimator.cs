using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimator  
{
    void Configure(IPlayerMediator player);

    void Dead();

    void Walk();

    void Idle();
}
