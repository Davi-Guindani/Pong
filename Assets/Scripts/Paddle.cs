using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;
    [SerializeField] private GameObject ball;
    public float speed = 5;
    [SerializeField] private Rigidbody2D rb;
    private Vector3 startPosition;
    private float movement;
    int gameMode = GameParameters.gameMode;
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
            else if (gameMode == 0) // SinglePlayer
            {
                if (ball.transform.position.y > this.transform.position.y + 0.5f)
                {
                    this.movement = 1;
                }
                else if (ball.transform.position.y < this.transform.position.y - 0.5f)
                {
                    this.movement = -1;
                }
                else
                {
                    this.movement = 0;
                }
            }
            else // Multiplayer
            {
                this.movement = Input.GetAxisRaw("Vertical2");
            }
            this.rb.velocity = new Vector2(this.rb.velocity.x, this.movement * this.speed);
        }
    }
    public void Reset()
    {
        this.speed = 5;
        this.rb.velocity = Vector2.zero;
        this.transform.position = this.startPosition;
    }
}
