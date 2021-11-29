using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   
    public float offset;

    public GameObject proiectil;
    public Transform shotPoint;

    private float time_intre_gloante;
    public float start_timp_intre_gloante;
    private void Update()
    {
        //abilitatea de a invarti camera la 360 cu mouse-ul
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0f,0f,rotZ+offset);



       
        if(time_intre_gloante<=0)
        {
             if (Input.GetMouseButtonDown(1))
        {
            Instantiate(proiectil, shotPoint.position, transform.rotation);
        }

        }
        else
        {
            time_intre_gloante -= Time.deltaTime;
        }
    }
}
