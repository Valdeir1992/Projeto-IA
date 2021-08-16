using UnityEngine;

public interface IPlayerMediator 
{
    void Moved(); 
    void Stopped(); 
    void Died();
    void ReceivedDamage(float amount); 
    Rigidbody GetRigidBody(); 
    float GetLifeMax();
}
