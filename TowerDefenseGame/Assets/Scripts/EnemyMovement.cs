using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Paths> path = new List<Paths>();
    [SerializeField] [Range(0f,20f)] float speed = 1f;
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Paths paths in path)
        {
            Vector2 startPosition = transform.position;
            Vector2 endPosition = paths.transform.position;
            float travelPercent = 0f;

            //transform.LookAt(endPosition); //TODO

            while(travelPercent < 1f) 
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector2.Lerp(startPosition, endPosition, travelPercent);
                
                yield return new WaitForEndOfFrame();
            }       
        }
    }

   
}
