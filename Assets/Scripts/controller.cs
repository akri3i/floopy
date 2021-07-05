using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class controller : MonoBehaviour
{
    int levelsUnlocked;
    // Start is called before the first frame update
    public Button[] buttons;
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);
        for(int i=0; i<buttons.Length;i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void load(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
