using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class but : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("levelMenu");
    }

}
