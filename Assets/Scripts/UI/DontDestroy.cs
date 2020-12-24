using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DontDestroy : MonoBehaviour
{
    #region Singleton

    public static DontDestroy instance;

    private void Awake()
    {
        instance = this;
    }


    #endregion

    public TMP_InputField input;
    public int seedInt = 0;
    public bool generateRandom;

    void Update()
    {
        seedInt = int.Parse(input.text);
        DontDestroyOnLoad(this.gameObject);
    }
}
