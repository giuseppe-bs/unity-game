using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rounds : MonoBehaviour {
    public float eletric;
    public float agua;
    public float tecnologia;
    public float comida;
    public float materiais;
    public float temp;
    public float tempbase;
    public float polution;
    public float a, e,t,f,p,m,t1p,t2p,t3,t1n,t2n;
    
    public int [,] invest;
    public int rodada;
    public int sciencepoints;

    private float aguab, eletricb, comidab, materiaisb, tecnologiab;


	void Start () {
        invest = new int[5,3];
        for(var i = 0; i < 5; i++)
        {
            for (var j = 0;j <3;j++)
            {
                invest[i,j] = 0;
            }
        }
        a = e = t = f = p = m = 0.2f;
        aguab = 0.5f;
        eletricb = 0.7f;
        comidab = 0.6f;
        materiaisb = 0.3f;
        tecnologiab = 0.4f;
	}

    //energi 0, food 1, resouces 2, tech 3, water 4;

    void round_update()
    {
        agua = aguab + (t1p * invest[4,0]) + (t2p * invest[4,1]) + (t3 * invest[4,2]) 
            - (t1n * (invest[0,0] + invest[1,0])) - (t2n*invest[1,1]);
        eletric = eletricb + (t1p * invest[0,0]) + (t2p * invest[0,1]) + (t3 * invest[0,2])
            - (t1n * (invest[3,0] + invest[4,0])) - (t2n * invest[3,1]);
        tecnologia = tecnologiab + (t1p * invest[3,0]) + (t2p * invest[3,1]) + (t3 * invest[3,2])
            - (t1n * invest[1,0]);
        comida = comidab + (t1p * invest[1,0]) + (t2p * invest[1,1]) + (t3 * invest[1,2])
            - (t1n * invest[3,0]) - (t2n * invest[3,1]);
        materiais = materiaisb + (t1p * invest[2,0]) + (t2p * invest[2,1]) + (t3 * invest[2,2])
            - (t1n * (invest[0,0] + invest[3,0]));
        polution = (e * eletric) - (t * tecnologia) - (a * agua) + (materiais * m) + (f * comida);
        temp = - (a * agua) + (p * polution) + tempbase;
    }

    //void new_round()
    //{

    //}
}
