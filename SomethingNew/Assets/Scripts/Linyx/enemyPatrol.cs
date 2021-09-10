//Script by Linyx adapted from a BlackThornProd video [https://www.youtube.com/watch?v=8eWbSN2T8TE]

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
   public float speed;  // float for speed.
   private float waitTime;  // creates a waitTime float variable for movement between points.
   public float startWaitTime;  // start of waitTime.

   public Transform[] movePositions;  // creates public array variable called moveSpots using Transform as main command.
   private int randomPosition;  // new private integer value called randomSpot, to be used in tandem with above array.

   void Start(){  // on the first frame set the waitTime to the startWaitTime and set the randomSpot to one in the range from 0 to the moveSpots length.
       waitTime = startWaitTime;
       randomPosition = Random.Range(0, movePositions.Length);
   }  

    // set the transform postion to move towards a random spot with the speed equal to time * deltaTime. (this applies for the whole block)
    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, movePositions[randomPosition].position, speed * Time.deltaTime); 
        

        if(Vector2.Distance(transform.position, movePositions[randomPosition].position) < 0.2f){
            if(waitTime <=0){
                randomPosition = Random.Range(0, movePositions.Length);
                waitTime = startWaitTime;
            } else {
                waitTime -= Time.deltaTime;
            }

        }
    }
}