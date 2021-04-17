using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    private int pontos = 0;
    private Text pontosS;
    private int timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        pontosS = GameObject.Find("pontosF").transform.Find("Pontos").GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCounter += 1;
        if(timeCounter>=50)
        {
            pontos++;
            pontosS.text = pontos.ToString();
            timeCounter = 0;
        }
    }

    public int getPontos()
    {
        return pontos;
    }
}
