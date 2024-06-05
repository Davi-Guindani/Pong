using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5;
    private Vector3 startPosition;
    [SerializeField] private Rigidbody2D rb;
    private void Start()
    {
        this.startPosition = this.transform.position;
        this.Launch();
    }

    public void Reset()
    {
        this.rb.velocity = Vector2.zero;
        this.transform.position = this.startPosition;
        this.Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        this.rb.velocity = new Vector2(this.speed * x, this.speed * y);
    }
}
