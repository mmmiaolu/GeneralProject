﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BtnRestart2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        Debug.Log("正常调用了点击事件 2");
        Time.timeScale = 1;
        SceneManager.LoadScene("Game2");
    }
}
