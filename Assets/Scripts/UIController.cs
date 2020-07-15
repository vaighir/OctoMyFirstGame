using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public int lives;

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
        
    }
}
