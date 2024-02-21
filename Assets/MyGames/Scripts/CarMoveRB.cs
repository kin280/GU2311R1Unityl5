using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CarMoveRB : MonoBehaviour
{
    private Rigidbody rb;
    public float speedPosition = 20;
    public float speedRotation = 50;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = UnityEngine.Input.GetAxis("Vertical");
        float h = UnityEngine.Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + new Vector3(0,0, v*Time.deltaTime*speedPosition));
        rb.MoveRotation(transform.rotation*Quaternion.Euler(new Vector3(0,h*Time.deltaTime*speedRotation,0)));
    }
}
