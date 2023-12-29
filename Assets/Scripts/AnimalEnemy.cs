using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalEnemy : Enemy
{
    public int tackleAttackPower=10;
    public int animalMovementSpeed = 20;
    public int animalHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        attackPower = tackleAttackPower;
        movementSpeed = animalMovementSpeed;
        health = animalHealth;
    }
    private void Update()
    {
        LookAtTarget();
        Move(Vector3.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Attack();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Weapon"))
        {
            GetDamage();
        }
    }
}
