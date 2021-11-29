using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Gloante : MonoBehaviour
{
    public int damage;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Viata_Inamici>().DamagePlayer(damage);
        }
        Destroy(gameObject);
    }
}
