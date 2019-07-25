using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    private int chapter = 1;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
    public void next(bool good)
    {
        ++chapter;
        if (good)
        {
            SceneManager.LoadScene("Chapter" + chapter.ToString());
        } else
        {
            SceneManager.LoadScene("Chapter" + chapter.ToString() + "p");
        }
    }
}
