using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : Photon.MonoBehaviour
{
    public GameObject Jogador1;
    public GameObject Jogador2;    
    public GameObject Jogador3;
    public GameObject Jogador4;
    [SerializeField]private GameObject lobbyCamera;
// Start is called before the first frame update
    void Start()
    {
 	PhotonNetwork.ConnectUsingSettings("1.0");       
    }

    void OnJoinedLobby()
    {
     	PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(){MaxPlayers=4}, TypedLobby.Default);   
    }

    void OnJoinedRoom(){
	PhotonNetwork.Instantiate("Jogador1", Jogador1.transform.position, Quaternion.identity,0);
	lobbyCamera.SetActive(false);
	PhotonNetwork.Instantiate("Jogador2", Jogador2.transform.position, Quaternion.identity,0);
	lobbyCamera.SetActive(false);
	PhotonNetwork.Instantiate("Jogador3", Jogador3.transform.position, Quaternion.identity,0);
	lobbyCamera.SetActive(false);
	PhotonNetwork.Instantiate("Jogador4", Jogador4.transform.position, Quaternion.identity,0);
	lobbyCamera.SetActive(false);
    }
}
