using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class SaveLoadSensibility : MonoBehaviour
{
    private BinaryWriter bW;
    private BinaryReader bR;
    private Slider sL;
    // Start is called before the first frame update
    void Start()
    {
        sL = transform.Find("Sensibilidade").transform.Find("Slider").GetComponent<Slider>();
        if (File.Exists(Application.persistentDataPath + @"\a.melao"))
        {
            sL.value = carregar();
        }
    }

    // Update is called once per frame
    public void salvar()
    {
        bW = new BinaryWriter(File.Open(Application.persistentDataPath+@"\a.melao", FileMode.OpenOrCreate));
        bW.Write(sL.value);
        bW.Close();
    }
    public float carregar()
    {
        bR = new BinaryReader(File.Open(Application.persistentDataPath + @"\a.melao",FileMode.Open));
        float valor = bR.ReadSingle();
        Debug.Log(valor);
        GameObject.Find("obj_Nave").GetComponent<Movimento_Nave>().alterarSensibilidade((int)valor*20) ;
        bR.Close();
        return valor;
    }
}
