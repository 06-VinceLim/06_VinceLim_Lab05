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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;

        timeText.text = "Time : " + time;

        if (time < 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Debug.Log("Touched coins");

            score += 10;

            scoreUi.text = "Score : " + score;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
