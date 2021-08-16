using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour, ICameraMotion
{
    private IPlayerMediator _player;

    private Camera _cameraMain;

    private Rigidbody _body;

    private Vector3 _currentDirection;

    [SerializeField] private float _xVelocity;

    [SerializeField] private float _yVelocity;
    public void Configure(IPlayerMediator player)
    {
        _player = player;

        _cameraMain = Camera.main;

        _body = player.GetRigidBody();
    }

    private void LateUpdate()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        if (_body == null) return;

        _currentDirection += new Vector3(Input.GetAxis("Mouse X") * _xVelocity,Input.GetAxis("Mouse Y") * _yVelocity);

        _currentDirection.y = Mathf.Clamp(_currentDirection.y, -60, 80);

        _body.transform.rotation = Quaternion.Euler(_body.transform.eulerAngles.x, _currentDirection.x, 0);

        Camera.main.transform.rotation = Quaternion.Euler(-_currentDirection.y,_body.transform.rotation.eulerAngles.y,_body.transform.rotation.eulerAngles.z); 
    }
}
