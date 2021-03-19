using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] GameObject Bullet;
    private SpriteRenderer mySprite;
    
        
        float nextFire;
    
        void Start()
        {
            mySprite = transform.GetComponentInChildren<SpriteRenderer>();
            
            nextFire = Time.time;
        }
    
        void Update()
        {
            CheckIfTimeToFire();
        }
    
        // ReSharper disable Unity.PerformanceAnalysis
        void CheckIfTimeToFire()
        {
            if(Time.time > nextFire)
            {
                var bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
                if (mySprite.flipX)
                {
                    bullet.GetComponent<projectilemovement>().projectileSpeed *= -1;
                }
                nextFire = Time.time + fireRate;
            }
        }
}
