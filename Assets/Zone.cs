using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public GameManagerControlTest gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        print("Hello my friend");
        GameObject newplant = Instantiate(gameManager.currentPlant, transform.position, transform.rotation);
        newplant.GetComponent<Planta>().enabled = false;
        Destroy(gameManager.currentPlant);
        gameManager.currentPlant = null;
    }
}
