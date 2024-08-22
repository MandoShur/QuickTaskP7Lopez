using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Get input from the horizontal and vertical axes
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 movement = new Vector2(moveX, moveY) * speed * Time.deltaTime;

        // Apply movement to the sprite's position
        transform.Translate(movement);
    }
}
