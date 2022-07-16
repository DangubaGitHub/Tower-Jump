using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text floorCountText;
    [SerializeField] Text pickupCounterText;

    void Start()
    {
        
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
}
