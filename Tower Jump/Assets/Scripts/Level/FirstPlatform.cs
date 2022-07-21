using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlatform : MonoBehaviour
{
    [SerializeField] float fallSpeed;
    Rigidbody2D platformRb2d;

    void Awake()
    {
        platformRb2d = GetComponent<Rigidbody2D>();  
    }

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Platform Destroyer"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlatformFall();
        }
    }

    void PlatformFall()
    {
        platformRb2d.velocity = new Vector2(0, -fallSpeed);
    }
}
