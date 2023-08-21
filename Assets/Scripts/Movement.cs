using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    private float force = 75;
    
    // Start is called before the first frame update
    void Start()
    {
        rb= gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal")*force*Time.deltaTime;
        float vInput = Input.GetAxis("Vertical") *force* Time.deltaTime;
        rb.AddForce(hInput, 0, vInput);
        
    }

   
}
