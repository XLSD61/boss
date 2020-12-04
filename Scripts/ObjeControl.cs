using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeControl : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 10, 0); // kendi etrafında döndüryorum

        Destroy(gameObject, 15f); // 15 saniye sonra ediyorum
    }
}
