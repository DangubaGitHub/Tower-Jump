using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    //[SerializeField] float scroleSpeed;
    [SerializeField] float number;
    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * DifficultyManager.instance.bgSpeed, number);
        transform.position = startPosition + Vector2.up * newPos;
    }
}
