using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 50;
    [SerializeField]float Health = 50;
    float damageAmount = 10;

    public Slider healthSlider;
    GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    { 
        if(other.gameObject.tag == "Katana")
        {     
            TakeDamage();
            EmpujarHaciaAtras();
        }
    }

    void EmpujarHaciaAtras()
    {
        Vector3 direccionGolpe = transform.position - jugador.transform.position;
        direccionGolpe.Normalize();

        float fuerzaEmpuje = 50f;
        transform.position += direccionGolpe * fuerzaEmpuje * Time.deltaTime;
    }

    public void TakeDamage()
    {
        Health -= damageAmount;
        ActualizeHealth();
        if(Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    void ActualizeHealth()
    {
        healthSlider.value = Health / maxHealth;
    }
}
