﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamikaze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision c){
       
       if (c.gameObject.CompareTag ("Player")){
            Debug.Log ("Moriste");      
            Destroy (this.gameObject);
       }
       
    }

}
