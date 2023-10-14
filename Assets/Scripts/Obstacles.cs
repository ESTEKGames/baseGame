using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    
    public GameObject pnlHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            pnlHit.SetActive(true);
            Cursor.visible = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
