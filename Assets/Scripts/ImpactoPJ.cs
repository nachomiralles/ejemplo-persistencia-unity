﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoPJ : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyTower")
        {
            Destroy(other.gameObject);
        }
        
    }

}
