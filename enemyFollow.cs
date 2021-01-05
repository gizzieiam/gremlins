using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float speed;
    public int distance;
    public GameObject player;
    
    // Start is called before the first frame update
    // Update is called once per frame

    void Update()
    {   
        // if player within distance
        if(Vector2.Distance(transform.position, player.transform.position) < distance)
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}