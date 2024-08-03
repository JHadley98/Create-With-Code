using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [Header("Plane Controls")]
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float verticalInput;

    [Header("Propeller Variables")]
    [SerializeField]
    GameObject propeller;
    [SerializeField]
    private float propellerSpeed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);

        // Rotate propeller on plane
        propeller.transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
