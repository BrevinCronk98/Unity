﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelf : MonoBehaviour
{
    public AudioSource soundeffect;
    public GameObject bookshelf;
    public PlayerController PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (PlayerScript.gamestate > 2)
        {
            bookshelf.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.gamestate > 2)
        {
            bookshelf.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.gamestate == 2)
      {
        PlayerScript.gamestate = 3;
        soundeffect.Play();
        bookshelf.SetActive(false);
      }
    }
  }
}