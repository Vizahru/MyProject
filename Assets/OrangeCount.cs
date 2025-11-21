using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class OrangeCount : MonoBehaviour
{
    
    [SerializeField] private TMPro.TextMeshProUGUI textBox;

    private int Oranges = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Oranges : " + Oranges;
    }

    public void PickUpOrange()
    {
        Oranges += 1;
        //Kunde inte ta bort en av colliders utan problem så det blir såhär.
    }
}