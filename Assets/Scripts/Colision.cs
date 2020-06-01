using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    public Patron Patron;
    public int Elemento; // 0 - BAUL ROJO | 1 MONEDA | 2 BAUL AZUL
    private Collider2D Collider2D;
    public Score Score;

    void Start()
    {
        Collider2D = GetComponent<Collider2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if(Patron.Patrones[Patron.Actual] != Elemento)
        {
            SceneManager.LoadScene(3);
            Score.OffGame();
            return;
        }
        else
        {
            if (Patron.Actual == Patron.Patrones.Count - 1)
            {
                Patron.Actual = 0;
                Patron.Patrones.Add(Random.Range(0, 3));
                StartCoroutine(Patron.MostrarPatron());
            }
            else
                Patron.Actual++;

            Score.AumentarPuntos();
        }
    }

}
