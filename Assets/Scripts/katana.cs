using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katana : MonoBehaviour
{
    public GameObject brokenBoxPrefab; // Prefab de la caja por partes
    public GameObject box;
    
    public Collider specifiedCollider;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Box") && collision.collider == specifiedCollider) // Comprueba si la colisión es con la caja
        {
            BreakBox(); // Llama a la función para romper la caja
        }
    }

    private void BreakBox()
    {
        // Instancia el prefab de la caja por partes en la misma posición y rotación
        Instantiate(brokenBoxPrefab, box.transform.position, box.transform.rotation);

        // Destruye la caja normal
        Destroy(box);
    }
}
