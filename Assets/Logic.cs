using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int score;
    public Text scoreVal;
    public GameObject gameOver;
    public bool active = true;

    [ContextMenu("Add Score")]
    public void addScore() {
        score += 5;
        scoreVal.text = score.ToString();
    }

    [ContextMenu("Lose")]
    public void endGame() {
        active = false;
        gameOver.SetActive(true);
    }

    public void startAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        active = true;
    }

    public bool getActive() {
        return active;
    }
}
