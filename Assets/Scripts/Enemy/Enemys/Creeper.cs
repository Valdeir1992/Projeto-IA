using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creeper : AbstractEnemy
{
    private Rigidbody _body;
    [SerializeField] private float _damageRadius;
    public override void Attack(Vector3 direction)
    {
        Collider[] targets = Physics.OverlapSphere(transform.position, _damageRadius);
    }

    public override void Dead()
    {
        Destroy(gameObject);
    }

    public override void Move(Vector3 direction)
    {
        _body.MovePosition(_body.position + direction * Time.fixedDeltaTime);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, _damageRadius);
    }
}
