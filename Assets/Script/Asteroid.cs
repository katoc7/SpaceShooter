using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    float aslife = 5f;

    void OnTriggerEnter2D()
    {
        aslife--;
        if (aslife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
