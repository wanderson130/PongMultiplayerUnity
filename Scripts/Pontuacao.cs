using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    Text t;
    // Start is called before the first frame update
    void Start()
    {
	t = this.gameObject.GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
	if(this.gameObject.name == "Pontos_2") t.text = ControladorBola.Pontuacao2.ToString();
	else t.text = ControladorBola.Pontuacao1.ToString();       
    }
}
