using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textScore;
    public MainPlayer mainPlayer;

    private void OnEnable()
    {
        mainPlayer.onCollisionWithPlaform += PlayerCollidedWithPlatform;   
    }

    private void OnDisable()
    {
        mainPlayer.onCollisionWithPlaform -= PlayerCollidedWithPlatform;
    }

    private void PlayerCollidedWithPlatform()
    {
        score++;
        textScore.text = score.ToString();
    }

}
