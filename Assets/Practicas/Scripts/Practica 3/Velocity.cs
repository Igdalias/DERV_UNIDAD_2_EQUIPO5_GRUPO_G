using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{

    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    float velocidad;

    [SerializeField]
    Transform posicion;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 10)
        {
            transform.position = posicion.position;
        }


        if (Input.GetKey(KeyCode.I))
        {
            rb.AddForce(transform.forward * velocidad, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(transform.forward * -1 * velocidad, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(transform.right * -1 * velocidad, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(transform.right * velocidad, ForceMode.VelocityChange);
        }
    }
}
