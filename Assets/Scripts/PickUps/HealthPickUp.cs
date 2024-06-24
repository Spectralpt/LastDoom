using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public float health;
    HealthManager player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        player.ChangeHealth(health);
        Destroy(gameObject);
    }
}
