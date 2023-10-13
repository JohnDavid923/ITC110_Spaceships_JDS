using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Adjust this speed as needed
    public float moveDistance = 4.0f; // Adjust this distance as needed
    private bool movingRight = true;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move the enemy left and right within the specified distance
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Check if the enemy should change direction
        if (Mathf.Abs(transform.position.x - startPosition.x) > moveDistance / 2)
        {
            movingRight = !movingRight;
        }
    }
}
