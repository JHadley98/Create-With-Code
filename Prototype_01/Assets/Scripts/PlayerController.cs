using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialise private variables
    [Header("Vehicle Controls")]
    [SerializeField] 
    private float moveSpeed = 20.0f;
    [SerializeField] 
    private float turnSpeed = 45.0f;
    [SerializeField] 
    private float horizontalInput;
    [SerializeField]
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
