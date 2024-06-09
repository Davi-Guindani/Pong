using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool isPlayer1Goal;
    [SerializeField] private GameManager gm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!this.isPlayer1Goal)
            {
                this.gm.Player1Scored();
            }
            else
            {
                this.gm.Player2Scored();
            }
        }
    }
}
