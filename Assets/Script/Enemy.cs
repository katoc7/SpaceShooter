using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float enemylife = 3f;
    public GameObject badBullet;

    void OnTriggerEnter2D()
    {
        Debug.Log("Collision con enemigo");
        enemylife--;

        if (enemylife <= 0)
        {
            Destroy(gameObject);
        }

      

    }
    /*
    void Update()
    {
        Instantiate(badBullet, transform.position + new Vector3(0.60f, 0, 0), Quaternion.identity);
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(1.5f);

    }
    */
}
