using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject levelDilog;
    public static UIHandler instance;

    void Awake()
    {
        if (instance== null)
        {
            instance = this;
        }
    }

    public void ShowLevelDilog()
    {
        levelDilog.SetActive(true);
    }
}
