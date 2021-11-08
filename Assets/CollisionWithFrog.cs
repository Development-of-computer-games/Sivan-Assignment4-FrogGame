using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithFrog : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshPro winner;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // when we catch a bomb falling, we want to eliminate all the enemies -> the spaceships that are falling
        if (other.tag == "Player")
        {
            Debug.Log("Finished the game successfully");
            winner.SetText("Winner!");
           

        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
