﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation2 : MonoBehaviour
{
   // public Transform teleportTarget;
   // public GameObject thePlayer;
   // public float velocity { get; internal set; }
  //  public Rigidbody rb;

    LevelManager letsRestart2;

    void Start()
    {
        Debug.Log("Teleportation2");
     //   rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "TeleFromHere") { 

            Debug.Log("Teleportation:  Restart Level");
            letsRestart2 = FindObjectOfType<LevelManager>();
            letsRestart2.RestartLevel();
            print(gameObject.name);

        }
        // thePlayer.transform.position = teleportTarget.transform.position;
        //  rb.velocity = Vector3.zero;
    }

}
