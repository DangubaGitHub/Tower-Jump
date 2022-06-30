using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump;

    float moveX;

    Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveX * speed * Time.deltaTime, rb2d.velocity.y);
    }
}
