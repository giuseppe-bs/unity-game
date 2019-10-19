using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dados : MonoBehaviour {
   /* private Text ag = GameObject.Find("Agua");
    private Text al = GameObject.Find("Alimentos");
    private Text ene = GameObject.Find("Energia");
    private Text tec = GameObject.Find("Tecnologia");
    private Text rec = GameObject.Find("Recursos");
    */
    public float agua;
    public float alimento;
    public float energia;
    public float tecnologia;
    public float recursos;
    void Start () {
        agua = 0.10f;
        alimento = 0.10f;
        energia = 0.4f;
        tecnologia = 0.6f;
        recursos = 0.4f;
	}
	
	// Update is called once per frame
	public void novoturno () {
		
	}
}
