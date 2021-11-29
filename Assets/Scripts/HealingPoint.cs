using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPoint : MonoBehaviour
{
    public int heal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player1"))
        {
            Viata_Jucator_1.viataActuala += heal;
            Destroy(gameObject);
        }
        if (collision.gameObject.name.Equals("Player2"))
        {
            Viata_Jucator_2.viataActuala += heal;
            Destroy(gameObject);
        }
        
    }
}
