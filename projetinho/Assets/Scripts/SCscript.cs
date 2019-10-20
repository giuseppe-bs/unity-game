using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCscript : MonoBehaviour {

    private GameObject t;
    private Text scp;
    private int[,] inv;
    private int custo;

    void Start () {
        t = GameObject.Find("Dados");
        scp = GameObject.Find("Sc").GetComponent<Text>();
 
    }
	
	// Update is called once per frame
	void Update () {
        scp.text = t.GetComponent<rounds>().sciencepoints.ToString();        
    }
    public void research(int i, int j)
    {
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
        t.GetComponent<rounds>().sciencepoints -= custo;
        inv = t.GetComponent<rounds>().invest;
        inv[i,j]++;
        t.GetComponent<rounds>().round_update();
        t.GetComponent<rounds>().new_round();
    }
}
