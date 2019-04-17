using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBola : MonoBehaviour
{	
    Vector3 velocidade;
    public static int Pontuacao1 = 0;
    public static int Pontuacao2 = 0;

    // Start is called before the first frame update
    void Start()
    {
	velocidade = new Vector3(0.1f, 0.1f);        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += velocidade;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
	if(c.gameObject.tag == "Parede")
		velocidade.y *= -1;
	if(c.gameObject.tag == "Jogador")
		velocidade.x *= -1;
	if(c.gameObject.name == "Pontos1"){
	 //Pontuacao1++;
	this.transform.position = Vector3.zero;
	}
	if(c.gameObject.name == "Pontos2"){
	 //Pontuacao2++;
	this.transform.position = Vector3.zero;
	}
	if(c.gameObject.name == "Pontos3"){
	 //Pontuacao3++;
	this.transform.position = Vector3.zero;
	}
	if(c.gameObject.name == "Pontos4"){
	 //Pontuacao4++;
	this.transform.position = Vector3.zero;   	
	}
    }
}
