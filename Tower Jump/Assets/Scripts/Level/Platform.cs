using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float fallSpeed;
    Rigidbody2D platformRb2d;

    void Awake()
    {
        platformRb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        platformRb2d.velocity = new Vector2(0, -fallSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Platform Destroyer"))
        {
            Destroy(gameObject);
        }

        if(other.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().enabled = false;

            GameManager.instance.levelCount++;
        }
    }
}
