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

    void Start()
    {
        menuPanel.SetActive(true);
        resetButton.SetActive(false);
    }

    void Update()
    {
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
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetScore()
    {

    }
}
