using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atualiza_status : MonoBehaviour {
    private GameObject t;
    private float water;
    private float energy;
    private float food;
    private float tec;
    private float res;
    private GameObject tagua;
    private GameObject ttec;
    private GameObject trec;
    private GameObject tcom;
    private GameObject tener;
    private Text ttagua;
    private Text tttec;
    private Text ttrec;
    private Text ttcom;
    private Text ttener;
    void Start () {
        t = GameObject.Find("Dados");
        tagua = GameObject.Find("Agua");
        ttec = GameObject.Find("Tecnologias");
        trec = GameObject.Find("Recursos");
        tcom = GameObject.Find("Comida");
        tener = GameObject.Find("Energia");
    }
	
	// Update is called once per frame
	void Update () {
        ttagua = tagua.GetComponent<Text>();
        tttec = ttec.GetComponent<Text>();
        ttrec = trec.GetComponent<Text>();
        ttcom = tcom.GetComponent<Text>();
        ttener = tener.GetComponent<Text>();
        ttagua.text = t.GetComponent<rounds>().agua.ToString("p1");
        tttec.text = t.GetComponent<rounds>().tecnologia.ToString("p1");
        ttrec.text = t.GetComponent<rounds>().materiais.ToString("p1");
        ttcom.text = t.GetComponent<rounds>().comida.ToString("p1");
        ttener.text = t.GetComponent<rounds>().eletric.ToString("p1");
        
    }
}
