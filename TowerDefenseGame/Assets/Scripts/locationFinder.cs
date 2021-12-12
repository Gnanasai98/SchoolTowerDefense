using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationFinder : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    public GameObject Tower;
    Vector2 vec;


    void OnMouseDown()
    {
        if(isPlaceable)
        {
            vec = transform.position;
            Instantiate(Tower, vec, Quaternion.identity);
            isPlaceable = false;
        }
    }


}
