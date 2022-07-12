using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    [SerializeField] float scroleSpeed = -2f;
    [SerializeField] float number;
    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scroleSpeed, number);
        transform.position = startPosition + Vector2.up * newPos;
    }
}
