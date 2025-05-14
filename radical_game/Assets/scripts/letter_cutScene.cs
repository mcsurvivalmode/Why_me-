using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class letter_cutScene : MonoBehaviour
{
    public void NextButton()
    {
        SceneManager.LoadScene("cutScene1");
    }
}
