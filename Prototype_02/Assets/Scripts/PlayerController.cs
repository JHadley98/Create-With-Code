using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declare Variables
    [Header("Controls")] 
    [SerializeField]
    private float speed;
    [SerializeField]
    private float horizontalInput;

    [Header("Boundaries")] [SerializeField]
    private float boundaryRange = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // Check if player is within the boundary range, so they don't go off the screen
        if (transform.position.x < -boundaryRange)
        {
            transform.position = new Vector3(-boundaryRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundaryRange)
        {
            transform.position = new Vector3(boundaryRange, transform.position.y, transform.position.z);
        }

        // Player input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move player left and right
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
