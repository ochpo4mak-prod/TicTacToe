﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAvA : MonoBehaviour
{
	public static int i = 0;

	public Text Text1;
	public Text Text2;
	public Text Text3;
	public Text Text4;
	public Text Text5;
	public Text Text6;
	public Text Text7;
	public Text Text8;
	public Text Text9;
	public Text text_player;
	public Text sign_player;
	public Text winner;

	public GameObject PlayerVsPlayer;
	public GameObject Victory;
	public GameObject Draw;

	public static string[,] ticTacField = new string[3, 3];
	public static string[] XO = new string[] {"X", "O", "X", "O", "X", "O", "X", "O", "X", "O", "X"};
	string[] player_number = new string[] {"AI 1", "AI 2", "AI 1", "AI 2", "AI 1", "AI 2", "AI 1", "AI 2", "AI 1", "AI 2", "AI 1"};
	bool change_sign = false; 

    void Update()
    {
        Text1.text = ticTacField[0, 0];
        Text2.text = ticTacField[0, 1];
        Text3.text = ticTacField[0, 2];
        Text4.text = ticTacField[1, 0];
        Text5.text = ticTacField[1, 1];
        Text6.text = ticTacField[1, 2];
        Text7.text = ticTacField[2, 0];
        Text8.text = ticTacField[2, 1];
        Text9.text = ticTacField[2, 2];

        if (change_sign = true)
        {
        	sign_player.text = XO[i];
            text_player.text = player_number[i] + "'s turn";
            winner.text = player_number[i+1] + " wins";
        	change_sign = false;
        }

        if (Text1.text == "X" && Text2.text == "X" && Text3.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text4.text == "X" && Text5.text == "X" && Text6.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text7.text == "X" && Text8.text == "X" && Text9.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text1.text == "X" && Text4.text == "X" && Text7.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text2.text == "X" && Text5.text == "X" && Text8.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text3.text == "X" && Text6.text == "X" && Text9.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text1.text == "X" && Text5.text == "X" && Text9.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text3.text == "X" && Text5.text == "X" && Text7.text == "X")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }

        else if (Text1.text == "O" && Text2.text == "O" && Text3.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text4.text == "O" && Text5.text == "O" && Text6.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text7.text == "O" && Text8.text == "O" && Text9.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text1.text == "O" && Text4.text == "O" && Text7.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text2.text == "O" && Text5.text == "O" && Text8.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text3.text == "O" && Text6.text == "O" && Text9.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text1.text == "O" && Text5.text == "O" && Text9.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (Text3.text == "O" && Text5.text == "O" && Text7.text == "O")
        {
        	PlayerVsPlayer.SetActive(false);
        	Victory.SetActive(true);
        }
        else if (i > 8)
        {
        	PlayerVsPlayer.SetActive(false);
        	Draw.SetActive(true);

        	//save in file
        	PlayerPrefs.SetString("player", player_number[i + 1]);
        	PlayerPrefs.SetString("dateAndTime", System.Convert.ToString(System.DateTime.Now));
        }
    }

    public void inptBut()
    {
    	rndInput();
    }

    public void rndInput()
    {
        int n = Random.Range(0, 3);
        int m = Random.Range(0, 3);
        
        if (i < 9)
        {
		    while (ticTacField[n, m] == "X" || ticTacField[n, m] == "O")
		    {
		    	n = Random.Range(0, 3);
		       	m = Random.Range(0, 3);
		    } 

	      	StartCoroutine(WaitSecond());

	    	IEnumerator WaitSecond()
		    {
		    	yield return new WaitForSeconds(1.0f);
		    	ticTacField[n, m] = XO[i];
	        	++i;
	        	rndInput(); 
		    }	               	
        }
    }
}