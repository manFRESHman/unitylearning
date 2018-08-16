﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFateTransitionAnimation : MonoBehaviour {
    public float m_timeLeft;
    float m_scale;
    [Range (6, 20)]
    public float m_scaleMultiplier = 12;

	// Use this for initialization
	void Start () {
        m_timeLeft = 0.5f;
        m_scale = 1;
	}
	
	// Update is called once per frame
	void Update () {
        m_timeLeft -= Time.deltaTime;
        m_scale += Time.deltaTime * m_scaleMultiplier;
        gameObject.transform.localScale = new Vector3(1, 1) * m_scale;

        if (m_timeLeft < 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1);
            m_timeLeft = 0.5f;
            m_scale = 1;
            gameObject.SetActive(false);
        }
	}
}
