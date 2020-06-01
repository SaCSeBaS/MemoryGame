using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Name : MonoBehaviour
{
    static public string Nombre;
    static public bool Guardado = false;
    private TextMeshProUGUI NameText;

    void Start()
    {
        NameText = GetComponent<TextMeshProUGUI>();

        if (Guardado)
            NameText.text = Nombre;
    }

    public void Guardar()
    {
        Nombre = NameText.text;
        Guardado = true;
    }

    public void Desguardar()
    {
        Nombre = "";
        Guardado = false;
    }
    
}
