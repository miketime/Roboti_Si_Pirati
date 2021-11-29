using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing_Spawn : MonoBehaviour
{
    public GameObject healing_point;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHeal", 3, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnHeal()
    {
        float x = Random.Range(-6.0f,6.0f);
        float y = Random.Range(-6.0f, 6.0f);
        Instantiate(healing_point, new Vector2(x, y), Quaternion.identity);
    }
}
