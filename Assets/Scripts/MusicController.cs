﻿//Made by Alexandre Jannuzzi & Alberto Menezes for Berklee Game Jam 2015

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MusicController : MonoBehaviour {

	public AudioSource [] sounds;
	public AudioSource layer1;
	public AudioSource layer2;
	public AudioSource layer3;
	public AudioSource layer4;
	public Text PTS;
	public Text PTS2;

	void Start () {
		sounds = GetComponents<AudioSource> ();
		layer1 = sounds [0];
		layer2 = sounds [1];
		layer3 = sounds [2];
		layer4 = sounds [3];
		layer1.volume = 1;
		layer2.volume = 0;
		layer3.volume = 0;
		layer4.volume = 0;
	}
	
	void FixedUpdate () {

		// This gets the scripts from player 1 and player 2 and then the current count
		GameObject player1 = GameObject.Find ("Player1");
		GameObject player2 = GameObject.Find ("Player2");
		Player01Movement player1movement = player1.GetComponent<Player01Movement> ();
		Player02Movement player2movement = player2.GetComponent<Player02Movement> ();

		//This will take off the sound that is played when the player wins the game.
		// This will also play a new sound
		if ((PTS.text == "P1 Points: 10") || (PTS2.text == "P2 Points: 10"))
		{

			layer2.volume = 0;
			layer3.volume = 0;
			layer4.volume = 1;

		}


		 else if ((player1movement.count >= 5 && player1movement.count < 8) || (player2movement.count >= 5 && player2movement.count < 8)) 
		{
			layer2.volume = 1;
			layer1.volume = 0;
		}
		else if ((player1movement.count >= 8 && player1movement.count < 10) || (player2movement.count >= 8 && player2movement.count < 10))
		{
			layer3.volume = 1;
			layer2.volume = 0;
		} 


		else
		{
			return;
		}



	}
}
