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

    void OnTriggerEnter(Collider other) 
    { 
        if(other.gameObject.tag == "Katana")
        {
            Debug.Log("Tocado");       
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        Debug.Log("Me quitan vida");
        Health -= damageAmount;

        if(Health <= 0)
        {
            Debug.Log("Estoy Muerto");
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Eliminando objeto");
        Destroy(this.gameObject);
    }
}
