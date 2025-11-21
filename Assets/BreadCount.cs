using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class BreadCount : MonoBehaviour
{
    
    [SerializeField] private TMPro.TextMeshProUGUI textBox;

    private int Breads = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Bread alive : " + Breads;
    }

    public void BreadDie()
    {
        Breads -= 1;
    }
}
