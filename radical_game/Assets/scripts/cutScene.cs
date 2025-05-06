using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutScene : MonoBehaviour
{
    public void SkipButton()
    {
        SceneManager.LoadScene("Level1");
    }
}
