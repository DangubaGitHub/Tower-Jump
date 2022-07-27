using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager instance;


    [Header("Difficulty Speed")]
    public float platformSpeed;
    public float platformSpawnRate;
    public float pickupSpeed;
    public float pickupSpawnRate;
    public float fgSpeed;
    public float bgSpeed;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GameManager.instance.difficultyCountDown = 3;
        platformSpeed = 0.3f;
        platformSpawnRate = 2f;
        pickupSpeed = 0.2f;
        pickupSpawnRate = 2f;
        fgSpeed = -0.18f;
        bgSpeed = -0.15f;
    }

    void Update()
    {
        DifficultyController();
    }

    public void DifficultyController()
    {   
        if(GameManager.instance.difficultyCountDown == 0)
        {
            platformSpeed += .1f;
            platformSpawnRate -= .5f;
            pickupSpeed += 0.1f;
            pickupSpawnRate -= 0.5f;
            fgSpeed -= 0.1f;
            bgSpeed -= 0.1f;

            GameManager.instance.difficultyCountDown = 3;
        }
    }
}
