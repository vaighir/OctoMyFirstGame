using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public Sprite[] sprites;
    private Sprite sprite;
    public OctoController octoController;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();   
    }

    private void InitializeVariables()
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, 8)];

        GameObject octo = GameObject.FindWithTag("Player");
        octoController = octo.GetComponent<OctoController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            octoController.Eat(1);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
        }
    }
}
