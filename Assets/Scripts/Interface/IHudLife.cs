using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHudLife  
{
    void Configure(IPlayerMediator player);

    void TakeDamage(float amount);
}
