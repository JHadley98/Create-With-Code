using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    // Initialise private variables
    [Header("Reference Player")]
    [SerializeField]
    private GameObject player;

    [Header("Camera Offset")]
    [SerializeField]
    private Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
