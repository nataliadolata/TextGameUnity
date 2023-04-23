using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Program zgaduje liczbe ktora wymyslilismy sobie z konkretnego przedzialu liczbowego
    // Mamy przedzial od 1 do 1000 i program pyta czy wymyslona liczba jest wieksza lub mniejsza lub rowna np. 328
    // Uzytkownik odpowiada wieksza lub mniejsza lub rowna
    int min = 1;
    int max = 1001;
    int shoot = 500;

    void Start()
    {
        
        Debug.Log("Witam w grze - pomysl w glowie liczbe od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna/mniejsza/wieksza od 500?");
        // print string
       
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe");
        }
    }
    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest rowna/mniejsza/wieksza od " + shoot + " ?");
    }
            
}
