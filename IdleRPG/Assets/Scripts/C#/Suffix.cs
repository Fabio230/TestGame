using System.Collections;
using UnityEngine;

public class Suffix : MonoBehaviour
{

	private static Suffix instance;
	public static Suffix Instance
	{
		get
		{
			return instance;
		}
	}

	void Awake (){
		CreateInstance ();
	}

	void CreateInstance()
		{
		if (instance == null)
		{
			instance = this;
		}
	}

	public string GetSuffix (float coins)
	{
		string converted;
		if (coins >= 1000000)
		{
			converted = (coins / 1000000f).ToString ("f3") + "M";
		} else if (coins >= 1000)
		{
			converted = (coins / 1000f).ToString ("f3") + "K";
		} else
		{
			converted = "" + coins;
		}
		return converted;
	}
}