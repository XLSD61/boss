﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;

    public Transform body;

    float xRot = 0f;

    private void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= rotY;
        xRot = Mathf.Clamp(xRot, -80, 80);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        body.Rotate(Vector3.up * rotX);

    }

}
