using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image soundON;
    [SerializeField] Image soundOFF;
    private bool muted = false;
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }
    
    // Update is called once per frame
    public void OnButtonPress()
    {
        if(muted==false)
        {
            muted = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundON.enabled = true;
            soundOFF.enabled = false;
        }
        else
        {
            soundON.enabled = false;
            soundOFF.enabled = true;
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
