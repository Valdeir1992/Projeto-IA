using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerMediator
{
    private Rigidbody _body;
    private IMotion _motionController;
    private ICameraMotion _cameraMotionController;
    private IDamage _damageController;
    private IHudLife _hudLife;
    private IAnimator _animatorController;

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();

        _motionController = GetComponent<IMotion>();
        _motionController.Configure(this);

        _cameraMotionController = GetComponent<ICameraMotion>();
        _cameraMotionController.Configure(this);

        _damageController = GetComponent<IDamage>();
        _damageController.Configure(this);

        _hudLife = GetComponent<IHudLife>();
        _hudLife.Configure(this);

        _animatorController = GetComponent<IAnimator>();
        _animatorController.Configure(this);

    }
    public Rigidbody GetRigidBody()
    {
        return _body;
    }

    public void Moved()
    {
        _animatorController.Walk();
    }

    public void Stopped()
    {
        _animatorController.Idle();
    }

    public void ReceivedDamage(float amount)
    {
        _hudLife.TakeDamage(amount);
    }

    public void Died()
    {
        _animatorController.Dead();
    }

    public float GetLifeMax()
    {
        return 5;
    }
}
