using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasHerencia: MonoBehaviour
{
    protected int vida;

    public void RecibirDaño(int cantidadDaño)
    {
        vida = vida - cantidadDaño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        Vector2 truePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = truePosition;
    }
}
