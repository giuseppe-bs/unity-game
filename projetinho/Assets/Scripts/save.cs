using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class save : MonoBehaviour {
    public float water;
    public float eletric;
    public float tecnologi;
    public float food;
    public float mat;

    public float temp;
    public float polut;

    int[][] constructions;

    int turno;
    public int scp;

    /*public data(Turn turn)
    {
        turno = turn.rodada;
        water = turn.agua;
        eletric = turn.eletric;
        tecnologi = turn.tecnologia;
        food = turn.comida;
        mat = turn.materiais;
        temp = turn.temp;
        polut = turn.polution;

    }
    */
}
