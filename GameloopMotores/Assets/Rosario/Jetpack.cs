using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    public int fuerzaJetpack = 10;
    private float rotacion = 50f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Horizontal") * rotacion * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaJetpack, ForceMode.Impulse);
            //Debug.Log("he pulsado espacio");
        }
    }
}
