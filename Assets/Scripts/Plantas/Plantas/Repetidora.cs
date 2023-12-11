using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetidora : PlantasHerencia
{
    public GameObject bulletPrefab;

    void Start()
    {
        vida = 80;
        InvokeRepeating("InstanciarBala", 35, 2);
    }

    void InstanciarBala()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

}

