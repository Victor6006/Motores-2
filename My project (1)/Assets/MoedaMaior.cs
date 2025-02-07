using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaMaior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("Moeda...");

            Player p = other.gameObject.GetComponent<Player>();

            p.pontos += 15;
            
            gameObject.SetActive(false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}