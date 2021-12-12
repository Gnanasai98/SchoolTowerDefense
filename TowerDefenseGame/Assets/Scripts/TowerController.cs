using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField] Transform tower;
    [SerializeField] Transform enemy;
    public float movespeed;

    void Start()
    {
        enemy = FindObjectOfType<EnemyMovement>().transform;
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        float xRotate = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yRotate = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        transform.Rotate(0, 0 , xRotate);

        
    }
}
