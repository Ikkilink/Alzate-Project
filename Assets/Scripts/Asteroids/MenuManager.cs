using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Canvas canvasGameOver;
    public MainPlayer player;
    private void OnEnable()
    {
        player.onTriggerEnter += PlayerDeath;
    }

    private void OnDisable()
    {
        player.onTriggerEnter -= PlayerDeath;
    }

    private void PlayerDeath()
    {
        canvasGameOver.enabled = true;
    }
}
