using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ParticleArcher : MonoBehaviour
{



    void Update()
    {

    }

    public IEnumerator DeactivateAfterDelayCoroutine()
    {
        yield return new WaitForSeconds(5f); // Esperar 5 segundos

        // Desactivar este script después del retraso
        gameObject.SetActive(false);
    }
}
