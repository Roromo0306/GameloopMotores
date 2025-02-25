using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack_capsule : MonoBehaviour
{
    public int fuerzaJetpack_capsule = 5;
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
        float rotate_horizontal = Input.GetAxis("Horizontal") * rotacion * Time.deltaTime;
        float rotate_vertical = Input.GetAxis("Vertical") * rotacion * Time.deltaTime;

        transform.Rotate(rotate_horizontal,rotate_vertical, 0);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaJetpack_capsule, ForceMode.Impulse);
            //Debug.Log("he pulsado espacio");
        }
    }
}