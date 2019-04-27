using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float maxspeed = 3f;

    public GameObject gameOverPanel;
    public GameObject gameOverText;
    public GameObject lifeText;
    public GameObject bullet;

    public Text liText;

    public SpriteRenderer nave;


    float life = 5f;


    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * maxspeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxspeed * Time.deltaTime;
        transform.position = pos;

        Power();
    }

    void Power()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(0.60f, 0, 0),Quaternion.identity);
        }
    }

    void OnTriggerEnter2D()
    {
        life--;
        liText.text = "Lives: " + life;
        ChangeRed();

        if (life <= 0)
        {
            Debug.Log("GAME OVER");

            gameOverText.SetActive(true);
        }
    }

    void ChangeRed()
    {
        nave = GetComponent<SpriteRenderer>();
        nave.color = Color.red;
        StartCoroutine(ChangeWhite());
    }

    IEnumerator ChangeWhite()
    {
        yield return new WaitForSeconds(1);
        nave.color = Color.white;
    }

}

 