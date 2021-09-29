using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public float hasaslýk;
    float xRot = 0;

    public GameObject kamera;
    void Rot()
    {
        xRot = Mathf.Clamp(xRot, -90, 90);

        float rotx = Input.GetAxisRaw("Mouse X") * hasaslýk * Time.deltaTime;
        float roty = Input.GetAxisRaw("Mouse Y") * hasaslýk * Time.deltaTime;

        xRot -= roty;

        transform.Rotate(transform.up * rotx);
        kamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);

    }
    private void Update()
    {

        Rot();
    }
}
