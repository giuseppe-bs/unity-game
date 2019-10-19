using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problemas : MonoBehaviour {
	public static float gw=29f, polution=0.3f;
	public Text a, b;
	// Use this for initialization
	void Start () {
		a.text = gw.ToString("####°C");
		b.text = polution.ToString ("P1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
