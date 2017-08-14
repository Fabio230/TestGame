#pragma strict

function Start () {

	this.GetComponent.<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume");
}

function Update () {

	this.GetComponent.<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume");
}
