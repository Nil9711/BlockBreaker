﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound = null;
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.countBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.BlockDestroyed(); 
        Destroy(gameObject);
    }

}
