﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FateInit : MonoBehaviour, SpellInit {
    public PredictionInit predictionInit;
    public Image fateTransition;
    private string[] aliases = { "fate" };
    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpellCreating>().addSpell(aliases, this);
        predictionInit = gameObject.GetComponent<PredictionInit>();
    }

    public void cast(SpellModificator sm)
    {
        if (predictionInit.spell)
        {
            predictionInit.spell.GetComponent<Prediction_FateLogic>().activateTransition();
            fateTransition.gameObject.SetActive(true);

            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
