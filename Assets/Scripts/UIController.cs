using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public int lives;
    public int score;
    public Text scoreText;
    public GameObject[] hearts;
    public Sprite heart;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        GameObject octo = GameObject.FindWithTag("Player");
        OctoController octoController = octo.GetComponent<OctoController>();
        lives = octoController.lives;

        // TODO get score from the appropriate controller
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i < lives)
            {
                hearts[i].SetActive(true);
            } else
            {
                hearts[i].SetActive(false);
            }
        }

        scoreText.text = "SCORE: " + score;
    }
}
