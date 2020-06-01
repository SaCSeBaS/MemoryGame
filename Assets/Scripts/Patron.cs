using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    public Sprite[] Sprites;
    [HideInInspector]
    public SpriteRenderer SpriteRenderer;

    [HideInInspector]
    public int Actual = 0;
    [HideInInspector]
    public List<int> Patrones;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Patrones = new List<int>();
        Patrones.Add(Random.Range(0, 3));
        StartCoroutine(MostrarPatron());
    }

    public IEnumerator MostrarPatron()
    {
        foreach(int i in Patrones)
        {
            Debug.Log(i);
            SpriteRenderer.sprite = Sprites[i];
            yield return new WaitForSeconds(1);
            SpriteRenderer.sprite = null;
            yield return new WaitForSeconds(0.5F);
        }
        SpriteRenderer.sprite = null;
    }
}
