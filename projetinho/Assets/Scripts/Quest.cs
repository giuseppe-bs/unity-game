using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {
    private GameObject t;
    private GameObject quest;
    private GameObject Question;
    private GameObject Awnswer;
    private GameObject Earth;

    void Start()
    {
        t = GameObject.Find("Dados");
        quest = GameObject.Find("Quiz1");
        Awnswer = GameObject.Find("Answer");
        Question = GameObject.Find("Pergunta");
        Earth = GameObject.Find("lowpoly_earth");
    }

    public void acerto()
    {
        t.GetComponent<rounds>().sciencepoints += 2;
        quest.SetActive(false);
        Earth.SetActive(true);
    }
    public void erro()
    {
        t.GetComponent<rounds>().sciencepoints -= 1;
        Awnswer.SetActive(true);
        Question.SetActive(false);
    }
}
