using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
		this.transform.position += new Vector3(0.1f,0);
	else if(Input.GetKey(KeyCode.A))
		this.transform.position -= new Vector3(0.1f,0);
    }
}
