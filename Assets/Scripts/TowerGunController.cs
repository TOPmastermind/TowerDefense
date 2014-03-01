﻿using UnityEngine;
using System.Collections;

public class TowerGunController : MonoBehaviour {

    // Config
    public Rigidbody2D rocket;
    public float speed;                     // Speed of the rocket
    public GameObject target;               // Target the rocket will fly to
    // public ArrayList;
    public GameObject[] enemyArray;         // All enemy exist on map
    public float fireRate;

	// Use this for initialization
	void Start () {
        // target = GameObject.FindGameObjectWithTag("Enemy");
        InvokeRepeating("Fire", 0, fireRate);
	}
	
	// Update is called once per frame
	void Update () 
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");

        /*
	    if (Input.GetButtonDown("Fire1"))
        {


        }
        **/

	}

    void Fire()
    {
        AimTarget();
        if (target != null)
        {
            Rigidbody2D rocketInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            rocketInstance.GetComponent<RocketController>().target = this.target;
        }
    }

    float Distance(GameObject a, GameObject b)
    {
        return (Mathf.Sqrt((a.transform.position.x - b.transform.position.x) * (a.transform.position.x - b.transform.position.x)
                           + (a.transform.position.y - b.transform.position.y) * (a.transform.position.y - b.transform.position.y)));
    }

    void AimTarget()
    {
        float minDistance = Mathf.Infinity;
        if (enemyArray.Length > 0)
        {
            foreach (GameObject g in enemyArray)
            {
                if (g != null)
                {
                    if (Distance(gameObject, g) < minDistance)
                    {
                        minDistance = Distance(gameObject, g);
                        target = g;
                    }
                }
            }
        }
    }


}