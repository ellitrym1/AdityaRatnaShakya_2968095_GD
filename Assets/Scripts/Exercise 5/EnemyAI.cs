using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    public Transform pointA;
    public Transform pointB;
    private Transform player;
    private Transform targetPoint;
    private bool isPlayerDetected = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        targetPoint = pointA;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);

        if(!isPlayerDetected) {
            patrol();
        }
        if(isPlayerDetected) {
            targetPoint = player;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player detected");
            player = other.transform;
            isPlayerDetected = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        player = null; 
        isPlayerDetected = false;
    }

    void patrol() {
        float distanceToTarget = Mathf.Abs(transform.position.x - targetPoint.position.x);
        if (distanceToTarget < 0.1f)
        {
            if (targetPoint == pointA)
            {
                targetPoint = pointB;
                spriteRenderer.flipX = true;
                // Debug.Log("Going to B");
            }
            else
            {
                targetPoint = pointA;
                spriteRenderer.flipX = false;
                // Debug.Log("Going to A");
            }
        }
    }
}
