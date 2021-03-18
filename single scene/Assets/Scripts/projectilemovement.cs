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
        if (enemy.transform.rotation.y == 0)
        {
            transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
        }
        else
        {

            transform.Translate(Vector2.left * projectileSpeed * Time.deltaTime);
        }
        
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Debug.Log("hit");
            /*Destroy(GameObject.FindWithTag("player"));
            _Gm.RespawnPlayer();#1#
        }
    }*/
   
}
