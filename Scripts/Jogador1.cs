﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
		this.transform.position += new Vector3(0,0.1f);
	else if(Input.GetKey(KeyCode.S))
		this.transform.position -= new Vector3(0,0.1f);
    }
}
