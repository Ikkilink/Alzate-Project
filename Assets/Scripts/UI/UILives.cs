using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILives : MonoBehaviour
{
    public Text Txtp1, Txtp2, Txtp3, Txtp4;
    GameManager manager;
    private void Start()
    {
        manager = GameManager.Instance;
    }

    void Update()
    {
        Txtp1.text = manager.lives.p1Lives.ToString();
        Txtp2.text = manager.lives.p2Lives.ToString();
        Txtp3.text = manager.lives.p3Lives.ToString();
        Txtp4.text = manager.lives.p4Lives.ToString();
    }
}
