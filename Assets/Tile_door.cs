using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_door : FindMG
{
    public LayerMask layer;

    private void Update()
    {

        Collider2D col = Physics2D.OverlapCircle(transform.position, 0.1f, layer);
        if (col)
        {
            GM.LevelPass();
        }


    }

}
