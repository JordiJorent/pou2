using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POTATO : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector3.left * velocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * velocity;
        }
    }

}
