using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;

    [Header("Player 1")]
    [SerializeField] private GameObject player1Paddle;
    [SerializeField] private GameObject player1Goal;

    [Header("Player 2")]
    [SerializeField] private GameObject player2Paddle;
    [SerializeField] private GameObject player2Goal;

    [Header("Score UI")]
    [SerializeField] private GameObject Player1Text;
    [SerializeField] private GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        this.Player1Score ++;
        this.Player1Text.GetComponent<TextMeshProUGUI>().text = this.Player1Score.ToString();
        this.ResetPosition();
    }
    public void Player2Scored()
    {
        this.Player2Score ++;
        this.Player2Text.GetComponent<TextMeshProUGUI>().text = this.Player2Score.ToString();
        this.ResetPosition();
    }
    private void ResetPosition()
    {
        this.ball.Reset();
        this.player1Paddle.GetComponent<Paddle>().Reset();
        this.player2Paddle.GetComponent<Paddle>().Reset();
    }
}
