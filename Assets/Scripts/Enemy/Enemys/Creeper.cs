using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creeper : AbstractEnemy
{
    private Rigidbody _body;
    [SerializeField] private float _damageRadius;

    private void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }
    public override bool Attack()
    {
        Collider[] targets = Physics.OverlapSphere(transform.position, _damageRadius);

        foreach (var item in targets)
        {
            if(item.TryGetComponent(out PlayerController playerController))
            {
                playerController.ReceivedDamage(3);

                Destroy(gameObject);

                return true;
            }
        }

        return false;
    }

    public override void Dead()
    {
        Destroy(gameObject);
    }

    public override void Move(Vector3 direction)
    {
        _body.MovePosition(_body.position + direction * Time.fixedDeltaTime * Data.MotionSpeed);

        transform.forward = direction;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, _damageRadius);
    }
}
