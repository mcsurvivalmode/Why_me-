using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreen : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("levelOne");
    }
}
