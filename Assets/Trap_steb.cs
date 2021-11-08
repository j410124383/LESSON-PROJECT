using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_steb : FindMG
{
    public LayerMask layer;
    public float time;
    public float startime =1f;

    private void Update()
    {

        Collider2D col = Physics2D.OverlapCircle(transform.position, 0.1f, layer);
        if (col)
        {
            time++;
        }

        if (time>startime)
        {
            PLAYER.GetComponent<PlayerState>().changeHP(-10);
            time = 0;
        }
    }

}
