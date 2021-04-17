using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class LerPontuacao : MonoBehaviour
{
    BinaryReader bR;
    // Start is called before the first frame update
    void Start()
    {
        if(File.Exists(Application.persistentDataPath + @"\pontuacoes.doceDeMarolo"))
        {
            bR = new BinaryReader(File.Open(@Application.persistentDataPath + @"\pontuacoes.doceDeMarolo", FileMode.Open));
            transform.Find("First").GetComponent<Text>().text=bR.ReadInt32().ToString();
            transform.Find("Second").GetComponent<Text>().text = bR.ReadInt32().ToString();
            transform.Find("Third").GetComponent<Text>().text = bR.ReadInt32().ToString();
            transform.Find("fourth").GetComponent<Text>().text = bR.ReadInt32().ToString();
            bR.Close();
        }
    }
}
