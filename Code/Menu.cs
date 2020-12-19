using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	public GameObject Menue;
	public GameObject Logo;
	public GameObject GameMode;
	public GameObject PlayerVsPlayer;
	public GameObject PlayerVsAi;
	public GameObject AiVsAi;
	public GameObject Victory;
	public GameObject Draw;

    public void ExitBut()
    {
    	Application.Quit();
    }

    public void StartBut()
    {
    	Menue.SetActive(false);

    	GameMode.SetActive(true);
    }

    public void PvP()
    {
    	GameMode.SetActive(false); 
    	Logo.SetActive(false);
    	PlayerVsPlayer.SetActive(true);
    }

    public void PvA()
    {
    	GameMode.SetActive(false); 
    	Logo.SetActive(false);
    	PlayerVsAi.SetActive(true);
    }

    public void AvA()
    {
		GameMode.SetActive(false); 
    	Logo.SetActive(false);
    	AiVsAi.SetActive(true);
    }

    public void BackToMenu()
    { 
    	Logo.SetActive(true);
    	Menue.SetActive(true);
    	Victory.SetActive(false);
    	Draw.SetActive(false);
    	Game.i = 0;
    	GamePvA.i = 0;
    	GameAvA.i = 0;
    	for (int k = 0; k < 3; k++)
    	{
    	    for (int l = 0; l < 3; l++)
    	    {
    	        Game.ticTacField[k, l] = "";
    	        GamePvA.ticTacField[k, l] = "";
    	        GameAvA.ticTacField[k, l] = "";
    	    }
    	}
    	
    }
}