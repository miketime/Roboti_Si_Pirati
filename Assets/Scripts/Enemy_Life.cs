using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Life : MonoBehaviour
{
    public float speed;
    public float distanta_de_oprire;
    public float retreatDistance;

    private float timp_intre_lovituri;
    public float start_timp_intre_lovituri;

    public GameObject proiectile; 
    public Transform jucator1;
    public Transform jucator2;
    // Start is called before the first frame update
    void Start()
    {
        jucator1 = GameObject.FindGameObjectWithTag("Player1").transform;
        jucator2 = GameObject.FindGameObjectWithTag("Player2").transform;
        timp_intre_lovituri = start_timp_intre_lovituri;
    }

    // Update is called once per frame
    void Update()
    {
        //p1
        if (Vector2.Distance(transform.position,jucator1.position)>distanta_de_oprire)
        {
            transform.position = Vector2.MoveTowards(transform.position, jucator1.position, speed*Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, jucator1.position) < distanta_de_oprire && (Vector2.Distance(transform.position, jucator1.position) > retreatDistance))
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, jucator1.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, jucator1.position, -speed * Time.deltaTime);
        }
        
        if (timp_intre_lovituri <= 0)
        {
            Instantiate(proiectile, transform.position, Quaternion.identity);
            timp_intre_lovituri = start_timp_intre_lovituri;
        }
        else
        {
            timp_intre_lovituri -= Time.deltaTime;
        }
    }
}
