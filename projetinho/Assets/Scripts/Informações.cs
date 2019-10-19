using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Informações : MonoBehaviour {
	public static float food=1f, res=1f, water=1f, tec=1f, energy=1f;
	public Text v, w, x, y, z;
	void Start () {
		v.text = water.ToString ("P1"); 
		w.text = food.ToString ("P1");
		x.text = energy.ToString ("P1");
		y.text = res.ToString ("P1");
		z.text = tec.ToString ("P1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
