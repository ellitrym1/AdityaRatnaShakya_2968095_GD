using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject gameObjects;

    void Start()
    {
        ShowStartMenu();
    }

    public void ShowStartMenu()
    {
        startMenuUI.SetActive(true);
        gameObjects.SetActive(false);
    }

    public void StartGame()
    {
        startMenuUI.SetActive(false);
        gameObjects.SetActive(true);
    }

    public void PlayerDeath()
    {
        gameObjects.SetActive(false);
        startMenuUI.SetActive(true);
    }

    public void OnStartButtonClick()
    {   
        Debug.Log("Button clicked");
        StartGame();
    }
}