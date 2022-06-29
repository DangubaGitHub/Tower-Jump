using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
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
