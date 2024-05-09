using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyBoardBase : MonoBehaviour
{
    public string CorrectCode = "L1F3";
    public string CurrentCode;

    public TextMeshPro tmp;

    public AudioSource audioo;

    public GameObject tvScreen;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = CurrentCode;
        if (CurrentCode ==  CorrectCode)
        {
            Destroy(tvScreen);
            audioo.Play();

            tmp.text = "You hear a sound in the bedroom...";
        }
    }
}
