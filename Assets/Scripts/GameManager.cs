using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text scoreUi;

    public Text timeText;

    int score;

    public float time;

    public int timeRemaining;

    int CoinsLeft;


    // Start is called before the first frame update
    void Start()
    {
        CoinsLeft = GameObject.FindGameObjectsWithTag("Coins").Length;
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;

        timeRemaining = Mathf.FloorToInt(time % 60);

        timeText.text = "Time : " + timeRemaining;

        if (time < 0)
        {
            SceneManager.LoadScene("LoseScene");
        }

        if (CoinsLeft <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Debug.Log("Touched coins");

            score += 10;

            scoreUi.text = "Score : " + score;

            CoinsLeft--;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
