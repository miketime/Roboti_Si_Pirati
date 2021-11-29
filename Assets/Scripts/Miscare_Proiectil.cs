using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscare_Proiectil : MonoBehaviour
{
    public int damage;


    public float speed;
    private Transform player1;
    private Transform player2;
    private Vector2 target1;
    private Vector2 target2;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1").transform;
        target1 = new Vector2(player1.position.x, player1.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target1, speed * Time.deltaTime);
        if (transform.position.x==target1.x && transform.position.y==target1.y)
        {
            DestroyProiectil();
        }
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {

            DestroyProiectil();
            collision.GetComponent<Viata_Jucator_1>().DamagePlayer(damage);
        }
    }
    void DestroyProiectil()
    {
        Destroy(gameObject);
    }
}
