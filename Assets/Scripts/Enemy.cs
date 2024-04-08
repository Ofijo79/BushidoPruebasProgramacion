using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]float Health = 50;
    float damageAmount = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Katana"))
        {
            TakeDamage();
        }    
    }

    public void TakeDamage()
    {
        Health -= damageAmount;

        if(Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
