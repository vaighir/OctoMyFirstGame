using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    public Sprite[] sprites;
    private Animator animator;
    private float speed, xDirection;
    
    public Vector2 maxPosition;
    public Vector2 minPosition;
    public Vector2 startPosition;
    private Vector2 targetPosition;

    private bool huntOcto;

    public GameObject octo;
    public OctoController octoController;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        speed = 10f;
        xDirection = 0f;

        SpriteRenderer s = GetComponent<SpriteRenderer>();
        GetComponent<SpriteRenderer>().sprite = sprites[0];
        
        animator = GetComponent<Animator>();

        octo = GameObject.FindWithTag("Player");
        octoController = octo.GetComponent<OctoController>();

        huntOcto = false;
    }

    // Update is called once per frame
    void Update()
    {
        DetectOcto();
        Move();

    }

    private void DetectOcto()
    {
        Vector2 octoPosition = octo.transform.position;
        
        if(octoPosition.x > minPosition.x && octoPosition.y > minPosition.y && octoPosition.x < maxPosition.x && octoPosition.y < maxPosition.y)
        {
            huntOcto = true;
        } else
        {
            huntOcto = false;
        }
    }

    private void Move()
    {
        if (huntOcto)
        {
            targetPosition = octo.transform.position;
        } else
        {
            targetPosition = startPosition; 
        }

        if(targetPosition.x > transform.position.x)
        {
            xDirection = 1f;
        } else
        {
            xDirection = -1f;
        }

        animator.SetFloat("xDirection", xDirection);

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            octoController.TakeDamage(3);
        }
    }
}
