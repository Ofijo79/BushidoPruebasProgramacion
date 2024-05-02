using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance;

    void Awake()
    {
        // Verifica si ya hay una instancia de este objeto en otra escena
        if (instance == null)
        {
            // Si no hay ninguna instancia, establece esta como la instancia actual
            instance = this;
            // No destruyas este objeto cuando cargues una nueva escena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia en otra escena, destruye este objeto
            Destroy(gameObject);
        }
    }
}
