using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM1 : MonoBehaviour
{
    /*
    public int lives = 3;
    public float resetDelay = 1f;
    public GameObject gameOver;
    public GameObject youWon;
    /*
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instance = null;
    */

    /*

void Start()
{
    if (instance == null)
    {
        instance = this;
    }
    else if (instance != this)
    {
        Destroy(gameObject);
    }

    Setup();


    resetB.onClick.AddListener(Reset);
}


public void Setup()
{
    clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    Instantiate(bricksPrefab, transform.position, Quaternion.identity);



}

void CheckGameOver()
{
    if (bricks < 1)
    {
        youWon.SetActive(true);
        //Time.timeScale = .25f;
        resetB.gameObject.SetActive(true);

    }

    else if (lives < 1)
    {
    public GameObject gameOver;
        gameOver.SetActive(true);
        //Time.timeScale = .25f;
        resetB.gameObject.SetActive(true);
    }
}

void Reset()
{
    //Invoke("Reset", resetDelay);
    //Application.LoadLevel(Application.loadedLevel);
    scoreText.text = "Score: " + score;
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void LoseLife()
{
    lives--;
    livesText.text = "Lives: " + lives;
    Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
    Destroy(clonePaddle);
    if (lives > 0)
    {
        Invoke("SetupPaddle", resetDelay);
    }
    CheckGameOver();
}


void SetupPaddle()
{
    clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
}

public void DestroyBrick()
{
    bricks--;
    CheckGameOver();
    score += 100;
}

*/

}
