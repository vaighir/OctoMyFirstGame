using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    public Sprite[] sprites;
    public OctoController octoController;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    public Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        GetComponent<SpriteRenderer>().sprite = sprites[0];

        GameObject octo = GameObject.FindWithTag("Player");
        octoController = octo.GetComponent<OctoController>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            octoController.TakeDamage(3);
        }
    }
}
