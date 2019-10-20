using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {
    private GameObject t;
    private GameObject quiz;
    private GameObject question;
    private GameObject resposta;
    private GameObject Earth;

    void Start()
    {
        t = GameObject.Find("Dados");
    }

    public void acerto()
    {
        t.GetComponent<rounds>().sciencepoints += 2;
    }
    public void erro()
    {
        t.GetComponent<rounds>().sciencepoints -= 1;
    }
}
