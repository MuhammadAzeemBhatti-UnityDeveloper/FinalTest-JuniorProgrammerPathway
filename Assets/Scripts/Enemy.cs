using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health=0;
    public int attackPower=0;
    public float movementSpeed = 0;
    public virtual PlayerController GetPlayerReference()
    {
        return PlayerController.manager;
    }
    public virtual void Move(Vector3 movingDirection)
    {
        transform.Translate(movingDirection * movementSpeed * Time.deltaTime);
    }
    public virtual void Attack()
    {
        Debug.Log("A Simple Enemy Attck");
        GetPlayerReference().p_health -= attackPower;
    }
    public virtual void GetDamage()
    {
        float amountOfDamage = GetPlayerReference().p_attack;
        health -= amountOfDamage;
        if(health<=0){Die();}
    }
   
    public virtual void Die()
    {
        Debug.Log("A Simple Enemy Died");
        GetPlayerReference().p_kills++;
    }
    public void LookAtTarget()
    {
        transform.LookAt(GetPlayerReference().gameObject.transform.position);
    }
}
