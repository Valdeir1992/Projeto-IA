using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour, IMotion
{
    private Rigidbody _body;

    private IPlayerMediator _player;

    private Vector3 _direction;

    [SerializeField] private float _velocity;

    private void Update()
    {
        _direction = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        _direction = Camera.main.transform.TransformDirection(_direction); 
    }

    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude > 0)
        { 
            Move(_direction);
            _player.Moved();
        }
        else
        {
            _player.Stopped();
        }
    }

    public void Configure(IPlayerMediator player)
    {
        _body = player.GetRigidBody();
        _player = player;
    }

    public void Move(Vector3 direction)
    {
        direction.y = 0; 
        _body.MovePosition(transform.position + direction.normalized * Time.fixedDeltaTime * _velocity); 
    } 
}
