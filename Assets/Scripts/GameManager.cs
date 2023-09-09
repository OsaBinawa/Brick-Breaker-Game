using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int life;
    public int score;
    public Text lifeText;
    public Text scoreText;
    public string NextScene;

    void Start()
    {
        lifeText.text = "Life " + life;
        scoreText.text = "Score " + score;
    }

    void Update()
    {
        if (life <= 0)
        {
            SceneManager.LoadScene(1);
        }
        if (score >=100)
        {
            SceneManager.LoadScene(NextScene);
        }
    }

    public void UpdateLife(int changeInLife)
    {
        life += changeInLife;
        lifeText.text = "Life " + life;
    }

    public void UpdateScore(int ChangeInScore)
    {
        score += ChangeInScore;
        scoreText.text = "Score " + score;
    }
}
