using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void OnClickStartGame()
    {
        SceneManager.LoadScene("Map");
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }
}
