using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Hardware;
using UnityEngine;

public class projectilemovement : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;
    private static GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(gameObject, 2f);
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }
   
}
