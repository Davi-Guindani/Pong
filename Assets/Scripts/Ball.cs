using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float initialSpeed = 5f; // Store the initial speed
    private float currentSpeed;
    private Vector3 startPosition;
    [SerializeField] private Rigidbody2D rb;
    private int collisionCount = 0;
    private const int collisionsToIncreaseSpeed = 5;
    private const float speedIncrementFactor = 1.05f; // 
    [SerializeField] private GameObject p1;
    [SerializeField] private GameObject p2;

    private void Start()
    {
        this.startPosition = this.transform.position;
        this.currentSpeed = this.initialSpeed;
        this.Launch();
    }

    public void Reset()
    {
        this.rb.velocity = Vector2.zero;
        this.transform.position = this.startPosition;
        this.currentSpeed = this.initialSpeed; // Reset the speed to the initial value
        this.collisionCount = 0; // Reset the collision count
        this.Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        this.rb.velocity = new Vector2(this.currentSpeed * x, this.currentSpeed * y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionCount++;
        if (collisionCount >= collisionsToIncreaseSpeed)
        {
            IncreaseSpeed();
            collisionCount = 0; // Reset the count after increasing speed
        }
    }

    private void IncreaseSpeed()
    {
        this.currentSpeed += this.initialSpeed * speedIncrementFactor;
        Vector2 currentVelocity = rb.velocity;
        Vector2 newVelocity = currentVelocity.normalized * this.currentSpeed;
        rb.velocity = newVelocity;
        this.p1.GetComponent<Paddle>().speed += 0.125f;
    }
}
