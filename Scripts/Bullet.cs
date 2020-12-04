using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   // public float speed = 50f;

    void Update()
    {
        //transform.Translate(Vector3.forward * -1 * Time.deltaTime * speed);
        Destroy(gameObject, 3.0f);
    }
}
