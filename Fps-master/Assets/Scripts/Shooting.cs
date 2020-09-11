﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera aCamera;
    public GameObject target;
    public GameObject GunEnd;
    LineRenderer ShotLine;
    WaitForSeconds ShotDuration = new WaitForSeconds(0.1f);
    // Start is called before the first frame update
    void Start()
    {
        ShotLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Shoot"))
        {
            RaycastHit hit;
            if(Physics.Raycast(aCamera.transform.position,aCamera.transform.forward,out hit)) // if the ray has hit some object
            {
                StartCoroutine(GunShooting());
                target.transform.position = hit.point;
                ShotLine.SetPosition(0, GunEnd.transform.position);
                ShotLine.SetPosition(1, hit.point);
             }
        }
    }

    IEnumerator GunShooting()
    {
       ShotLine.enabled = true;
       yield return ShotDuration;
       ShotLine.enabled = false;
    }
}
