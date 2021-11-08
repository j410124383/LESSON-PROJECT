using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMG : MonoBehaviour
{

    protected GameObject PLAYER;
    protected PlayerState PS;
    protected GameManager GM;

    private void Awake()
    {
        PLAYER = GameObject.FindWithTag("Player");
        PS = PLAYER.GetComponent<PlayerState>();
        GM= GameObject.FindWithTag("GM").GetComponent<GameManager>();
    }

}
