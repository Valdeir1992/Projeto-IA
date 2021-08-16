using UnityEngine;

public interface IMotion
{
    void Configure(IPlayerMediator player);
    void Move(Vector3 direction);
}