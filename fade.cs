//Intan Mayang Puri Chairunnissa Sistem Informasi Universitas Gunadarma
//Email	: deintanmayang@student.gunadarma.ac.id
//http://15114372.student.gunadarma.ac.id/
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {
    //name of the scene you want to load
    public string scene;
	public Color loadToColor = Color.white;
	
	// Update is called once per frame
	void OnGUI () {
			Initiate.Fade(scene,loadToColor,5f);	
	}
}
