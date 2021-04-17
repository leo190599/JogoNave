using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuFunctions : MonoBehaviour
{
    private GameObject pauseButton, pointCounter,mainMenu;
    // Start is called before the first frame update
    private void Start()
    {
        mainMenu = GameObject.Find("MainMenu").gameObject;
        mainMenu.SetActive(false);
        pauseButton = transform.Find("PauseButton").gameObject;
        pointCounter = transform.Find("pontosF").gameObject;
    }
    public void pauseGame()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            pointCounter.SetActive(false);
            pauseButton.SetActive(false);
            mainMenu.SetActive(true);
        }
        else
        {
            mainMenu.SetActive(false);
            Time.timeScale = 1;
            pointCounter.SetActive(true);
            pauseButton.SetActive(true);
            GameObject.Find("obj_Nave").GetComponent<Movimento_Nave>().unPause();
        }
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
