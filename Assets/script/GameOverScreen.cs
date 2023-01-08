using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
