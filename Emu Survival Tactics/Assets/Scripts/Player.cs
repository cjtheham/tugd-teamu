/*
 * Created: 11/2/2022
 * Created by: Krieger
 * 
 * Modified:
 * 
 * Description: Handles player character behavior
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);

        rb.velocity = movement;
        Debug.Log(rb.velocity);
    }
}
