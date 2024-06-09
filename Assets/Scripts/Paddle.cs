using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;
    [SerializeField] private GameObject ball;
    private float speed = 5;
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
            Debug.Log("Entrou em update/nao pausado");
            if (isPlayer1)
            {
                Debug.Log("é o player 1 mexendo");
                this.movement = Input.GetAxisRaw("Vertical");
            }
            else if (gameMode == 0) // SinglePlayer
            {
                Debug.Log("é a ia mexendo");
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
                Debug.Log("é o p2 mexendo");
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
