using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop_kit : FindMG
{
    public LayerMask layer;

    private void Update()
    {

        Collider2D col = Physics2D.OverlapCircle(transform.position, 0.1f, layer);
        if (col)
        {
            PLAYER.GetComponent<PlayerState>().changeHP(20);
            Die();
        }

    }


    void Die()
    {
        Destroy(this.gameObject);
    }
}
