using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int score, lives;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        score = 0;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            ExitToMenu();
        }
    }

    public void UpdateScore(int value)
    {
        score += value;
    }

    public void UpdateLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            ExitToMenu();
        }
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Win()
    {
        SceneManager.LoadScene("Success");
    }
}
