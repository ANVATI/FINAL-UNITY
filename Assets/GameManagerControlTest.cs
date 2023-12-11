using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerControlTest : MonoBehaviour
{
    public GameObject plantPrefab;
    public GameObject currentPlant;

    void Start()
    {

    }


    void Update()
    {

    }
    public void CreatePlant()
    {
        if (currentPlant == null)
        {
            currentPlant = Instantiate(plantPrefab, transform.position, transform.rotation);

        }
    }
}
