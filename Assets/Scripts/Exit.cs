using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public Name Name;
    public Score Score;

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            Name.Desguardar();
            Score.ResetearPuntos();
            Score.InGame();
            SceneManager.LoadScene(0);
        }
    }
}
