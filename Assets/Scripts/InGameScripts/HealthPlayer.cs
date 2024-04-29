using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField]float health = 100;
    float damageAmount = 10;
    float damageAmountBullet = 20;

    public Slider healthSlider;

    Isometriccontroller dash;
    // Start is called before the first frame update
    void Start()
    {
        dash = GetComponent<Isometriccontroller>();
    }

    void OnTriggerEnter(Collider other) 
    { 
        if(other.gameObject.tag == "Arma" && dash.isDashing == false)
        {     
            GetDamage();
        }
        
        if(other.gameObject.tag == "Bullet" && dash.isDashing == false)
        {     
            GetDamageBullet();
        }
    }

    public void GetDamageBullet()
    {
        health -= damageAmountBullet;
        ActualHealth();
        if(health <= 0)
        {
            Die();
        }
    }

    public void GetDamage()
    {
        health -= damageAmount;
        ActualHealth();
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
    
    void ActualHealth()
    {
        healthSlider.value = health / maxHealth;
    }
}
