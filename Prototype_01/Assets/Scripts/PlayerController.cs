using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField][Header("Vehicle Controls")]
    private float moveSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        
    }
}