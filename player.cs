using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStat
    {
        public int health = 100;
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        string label = hit.collider.gameObject.tag;
        if (label == "enemies" )
        {
            print("hi");
            // health = health - 1;
            // if(health == 3)
            // {
            //     print("health = " + health);
            // }
            // else if(health == 2)
            // {
            //     // lose one heart
            //     print("health = " + health);
            // }
            // else if(health == 1)
            // {
            //     //lose one heart
            //     print("health = " + health);
            // }
            // else
            // {
            //     print("game over");
            // }
        } 
    }
}
