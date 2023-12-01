using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;

    void OnTriggerEnter()
    {
        PlayEndSequence();
    }

    void PlayEndSequence()
    {
        completeLevelUI.SetActive(true);
    }
}
