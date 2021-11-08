using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisionWithFrog : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        // when we catch a bomb falling, we want to eliminate all the enemies -> the spaceships that are falling
        if (other.tag == "Player")
        {
            Debug.Log("Game-Over, there was a collision with a car!");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
