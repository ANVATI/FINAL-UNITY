using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public MusicControl musicControl;
    public int points;
    public int Soles = 2000;
    public Text TextPoints;
    public Text TextSoles;
    public GameObject plantPrefab;
    public GameObject currentPlant;
    public GameObject Options;
    
    void Start()
    {
        UpdatePoints(0);
        UpdateSoles();
    }
    public void UpdateSoles()
    {
        TextSoles.text = "" + Soles;
    }
    public void UpdatePoints(int score)
    {
        points = points + score;
        TextPoints.text = "Zombies Eliminados: " + points;

        if (points == 1)
        {
            SceneManager.LoadScene("Win");
        }
    }
    /*
    void Update()
    {
        if (Input.GetAxisRaw("Fire1") != 0)
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
    */
    public void AppearOptionsContainer()
    {
        Options.SetActive(true);
        Time.timeScale = 0;
    }
    public void DisappearOptionsContainer()
    {
        Options.SetActive(false);
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
        Options.SetActive(false);
        Time.timeScale = 1;
    }
    public void ReturnMenú()
    {
        SceneManager.LoadScene("Menú");
        Time.timeScale = 1;
    }
    public void CreatePlant()
    {
        if (currentPlant == null) 
        {
           currentPlant = Instantiate(plantPrefab, transform.position, transform.rotation);

        }
    }
}
