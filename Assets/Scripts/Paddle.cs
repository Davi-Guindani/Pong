using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;
    private float speed = 5;
    [SerializeField] private Rigidbody2D rb;
    private Vector3 startPosition;
    private float movement;
    void Start()
    {
        this.startPosition = this.transform.position;
    }
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (isPlayer1)
            {
                this.movement = Input.GetAxisRaw("Vertical");
            }
            else
            {
                this.movement = Input.GetAxisRaw("Vertical2");
            }
            this.rb.velocity = new Vector2(this.rb.velocity.x, this.movement * this.speed);
        }
    }
    public void Reset()
    {
        this.rb.velocity = Vector2.zero;
        this.transform.position = this.startPosition;
    }
}
