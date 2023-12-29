using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanEnemy : Enemy
{
    public int weaponAttackPower = 10;
    public int humanMovementSpeed = 20;
    public int humanHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        attackPower = weaponAttackPower;
        movementSpeed = humanMovementSpeed;
        health = humanHealth;
    }

    // Update is called once per frame
    void Update()
    {
        LookAtTarget();
        Move(Vector3.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Attack();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            GetDamage();
        }
    }
}
