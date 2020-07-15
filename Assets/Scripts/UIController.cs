using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public int lives;
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
    }
}
