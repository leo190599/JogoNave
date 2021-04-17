using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SalvarPontuacao : MonoBehaviour
{
    BinaryWriter bW;
    BinaryReader bR;
    List<int> pontuacoes;
    // Start is called before the first frame update
    void Start()
    {
        pontuacoes = new List<int>();
        if (File.Exists(Application.persistentDataPath+@"\pontuacoes.doceDeMarolo"))
        {
            bR = new BinaryReader(File.Open(Application.persistentDataPath + @"\pontuacoes.doceDeMarolo", FileMode.Open));
            for(int i=0;i<4;i++)
            {
                pontuacoes.Add(bR.ReadInt32());
            }
            bR.Close();
        }
        else
        {
            for(int i=0;i<3;i++)
            {
                pontuacoes.Add(0);
            }
        }
    }

     public void salvarPontos(int novaPontuacao)
    {
       pontuacoes.Add(novaPontuacao);
       pontuacoes.Sort(new comparador());
        bW = new BinaryWriter(File.Open(Application.persistentDataPath + @"\pontuacoes.doceDeMarolo", FileMode.OpenOrCreate));
       for(int i=0;i<4;i++)
        {
            bW.Write(pontuacoes[i]);
        }
        bW.Close();
    }
}

public class comparador : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if(x>y)
        {
            return -1;
        }
        else if(x<y)
        {
            return 1;
        }
        return 0;
    }
}