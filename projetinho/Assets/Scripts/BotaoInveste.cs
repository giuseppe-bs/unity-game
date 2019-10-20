using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoInveste : MonoBehaviour {
    public int i, j;
    private GameObject sc;
    private GameObject t;
    private int custo;

    // Use this for initialization
    public void OnClick() {
        t = GameObject.Find("Dados");
        switch (j)
        {
            case 0:
                custo = 2;
                break;
            case 1:
                custo = 3;
                break;
            case 2:
                custo = 5;
                break;
        }
        if (custo > t.GetComponent<rounds>().sciencepoints) return;
        sc = GameObject.Find("PainelCiencia");
        sc.GetComponent<SCscript>().research(i, j);

	}
}
