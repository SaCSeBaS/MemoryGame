using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    static public int Points = 0;
    static public bool isInGame = true;
    private TextMeshProUGUI ScoreText;

    void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    void OnGUI()
    {
        if (isInGame)
            ScoreText.text = "Puntos: " + Points.ToString();
        else
            ScoreText.text = ": " + Points.ToString() + " puntos";
    }

    public void AumentarPuntos()
    {
        Points++;
    }

    public void ResetearPuntos()
    {
        Points = 0;
    }

    public void OffGame()
    {
        isInGame = false;
    }

    public void InGame()
    {
        isInGame = true;
    }
}
