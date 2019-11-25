using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject canos;
	int score = 0;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.white;
		GUI.skin.label.fontSize = 50;
        GUILayout.Label(" Pontos: " + score.ToString());
	}
	
	void CreateObstacle()
	{
		Instantiate(canos);
		score++;
	}
}
