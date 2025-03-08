using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    public LifeManager lives = new LifeManager();
    public int playerlives;
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        lives.p1Lives = playerlives;
        lives.p2Lives = playerlives;
        lives.p3Lives = playerlives;
        lives.p4Lives = playerlives;
    }

    public void Takelife(int player)
    {
        switch (player)
        {
            case 1:
                if (lives.p1Lives <= 0) return;
                lives.p1Lives--;
                break;
            case 2:
                if (lives.p2Lives <= 0) return;
                lives.p2Lives--;
                break;
            case 3:
                if (lives.p3Lives <= 0) return;
                lives.p3Lives--;
                break;
            case 4:
                if (lives.p4Lives <= 0) return;
                lives.p4Lives--;
                break;
        }
    }
}
