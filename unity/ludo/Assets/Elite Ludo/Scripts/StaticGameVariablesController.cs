﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticGameVariablesController : MonoBehaviour
{

    public Sprite[] avatars;

    public Sprite[] emoji;

    public int emojiPerPack = 12;
    public int packsCount = 6;

    public GameObject appUpdatePopup;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        StartCoroutine(appUpdatePopup.GetComponent<AppUpdatePopup>().CheckVersion());
    }

    // Update is called once per frame
    public void destroy()
    {
        if (this.gameObject != null)
            DestroyImmediate(this.gameObject);
    }
}
