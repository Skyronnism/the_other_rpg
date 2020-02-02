﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
            MoveOnClick();
    }

    private void MoveOnClick()
    {
       Ray positionFinder = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit;
       bool hasHit = Physics.Raycast(positionFinder, out hit);
       if(hasHit)
        GetComponent<NavMeshAgent>().destination = hit.point;

    }
}
