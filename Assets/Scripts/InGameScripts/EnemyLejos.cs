using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLejos : MonoBehaviour
{
    public Transform player;
    public float visionRange = 10f;
    public float rotationSpeed = 5f;
    public GameObject flechaPrefab;
    public Transform shootPoint;
    public float cadencyShoot = 1f;

    private float shootTime = 0f;

    void Update()
    {

        Vector3 directionToPlayer = player.position - transform.position;
        float playerDistance = directionToPlayer.magnitude;

        if (playerDistance <= visionRange)
        {

            Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToPlayer, rotationSpeed * Time.deltaTime);


            if (Time.time >= shootTime)
            {
                Shoot();
                shootTime = Time.time + 1f / cadencyShoot;
            }
        }
    }

    void Shoot()
    {

        GameObject flecha = Instantiate(flechaPrefab, shootPoint.position, shootPoint.rotation);

        flecha.GetComponent<Rigidbody>().AddForce(shootPoint.forward * 10f, ForceMode.Impulse);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
