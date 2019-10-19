using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Satisf : MonoBehaviour {
	public static float sat=0.6f;
	public Text txt;

	// Use this for initialization
	void Start () {
		txt.text = sat.ToString ("P");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
