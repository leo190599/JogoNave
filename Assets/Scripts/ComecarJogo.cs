using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComecarJogo : MonoBehaviour
{
    public void comecar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
