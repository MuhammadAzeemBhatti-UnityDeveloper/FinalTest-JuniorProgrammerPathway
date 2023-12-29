using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int health;
    private int kills;
    private float attack;
    public int p_health 
    {
    get { return health; }
    set { health = value; }
    }
    public int p_kills
    {
        get { return kills; }
        set { kills = value; }
    }
    public float p_attack
    {
        get { return attack; }
    }
    public static PlayerController manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
