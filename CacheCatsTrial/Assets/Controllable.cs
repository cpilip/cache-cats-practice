using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllable : MonoBehaviour
{
    private Vector2 moveDirection;
    private Vector2 previousPosition;
    private Rigidbody2D playerRigidbody2D;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle Movement.
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        float verticalInput = Input.GetAxisRaw("Vertical"); // -1, 0, 1

        moveDirection = new Vector2(horizontalInput * speed, verticalInput * speed);
    }

    private void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + moveDirection * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("DEBUG: Hit the box.");

        previousPosition = playerRigidbody2D.position;
        playerRigidbody2D.MovePosition(previousPosition);
    }
}
