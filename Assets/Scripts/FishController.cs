using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public Sprite[] sprites;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();   
    }

    private void InitializeVariables()
    {
        SpriteRenderer s = GetComponent<SpriteRenderer>();
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, 8)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
