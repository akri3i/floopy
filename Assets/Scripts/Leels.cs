using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leels : MonoBehaviour
{
    private enimies[] _enemies;
    private object enemy;
    private static int _nextLevelIndex =1;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<enimies>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (enimies enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }
            
            _nextLevelIndex++;
            string nextLevelName = "Level" + _nextLevelIndex;
            SceneManager.LoadScene(nextLevelName);
    }
}
