using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barras : MonoBehaviour {
    private Text pol;
    private Text te;
    private GameObject t;
    private Slider st;
    private Slider sp;
    void Start () {
        pol = GameObject.Find("Poluição").GetComponent<Text>();
        te = GameObject.Find("Temperatura").GetComponent<Text>();
        st = GameObject.Find("SliderT").GetComponent<Slider>();
        sp = GameObject.Find("SliderP").GetComponent<Slider>();
        t = GameObject.Find("Dados");
    }
	
	// Update is called once per frame
	void Update () {
        pol.text = t.GetComponent<rounds>().polution.ToString("p1");
        te.text = t.GetComponent<rounds>().temp.ToString("####°C");
        st.value = (t.GetComponent<rounds>().temp)/25;
        sp.value = t.GetComponent<rounds>().polution;

    }
}
