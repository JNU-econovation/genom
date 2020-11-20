﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{ 
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerControllUi;
    private Rigidbody2D playerRigidbody;
    //[SerializeField] PonController KingController; 
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerKilledByEnemy()
    {
        Destroy(player);
        Destroy(playerControllUi);
    }





}
