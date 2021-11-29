using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Melee : MonoBehaviour
{
    private float timp_intre_atacuri;
    public float start_Timp_intre_atacuri;

    public Transform attack_pozitie;
    public float attack_Range;
    public LayerMask what_is_enemies;
    public int damage;
    public Animator animator;
    private void Update()
    {
        if(timp_intre_atacuri<=0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attack_pozitie.position,attack_Range,what_is_enemies);
                for(int i=0;i<enemiesToDamage.Length;i++)
                {
                    enemiesToDamage[i].GetComponent<Viata_Inamici>().DamagePlayer(damage);
                    
                }
                animator.SetBool("attack", true);
            }
            //ataci
            timp_intre_atacuri = start_Timp_intre_atacuri;
        }
        else
        {
            timp_intre_atacuri -= Time.deltaTime;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("attack", false);
        }
        
    }
    void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(attack_pozitie.position, attack_Range);
        }
}
