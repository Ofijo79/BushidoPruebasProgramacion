using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivationBoss : MonoBehaviour
{
    BossEnemy enemyScriptObject;
    public GameObject vidaBoss;
    // Start is called before the first frame update
    void Start()
    {
        enemyScriptObject = GameObject.Find("Oni").GetComponent<BossEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            enemyScriptObject.enabled = true;
            vidaBoss.SetActive(true);
        }
    }
}
