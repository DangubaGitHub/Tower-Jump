using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] Text floorCountText;
    [SerializeField] Text pickupCounterText;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject resetButton;

    bool menuIsOn;

    void Start()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
        resetButton.SetActive(false);
    }

    void Update()
    {
        if(menuIsOn)
        {
            Time.timeScale = 0;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!menuIsOn)
            {
                menuIsOn = true;
                menuPanel.SetActive(true);
            }
        }

        UpdateFloorCount();
        UpdatePickupCount();
    }

    void UpdateFloorCount()
    {
        floorCountText.text = GameManager.instance.levelCount.ToString();
    }

    void UpdatePickupCount()
    {
        pickupCounterText.text = GameManager.instance.collectibleCount.ToString();
    }

    public void StartGame()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
        menuIsOn = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetScore()
    {

    }
}
