using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorMainMenu : MonoBehaviour
{
    private GameObject[] menus;
    // Start is called before the first frame update
    void Start()
    {
        menus = new GameObject[2];
        menus[0] = transform.Find("Menu1").gameObject;
        menus[1] = transform.Find("Pontuacao").gameObject;
        menus[1].SetActive(false);
    }

    public void irMainMenu()
    {
        menus[0].SetActive(true);
        menus[1].SetActive(false);
    }

    public void irHighscores()
    {
        menus[0].SetActive(false);
        menus[1].SetActive(true);
    }
}
