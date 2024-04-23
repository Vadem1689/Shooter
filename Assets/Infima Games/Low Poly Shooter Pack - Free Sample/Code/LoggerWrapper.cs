using InfimaGames.LowPolyShooterPack;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnityLogger
{
	public void Log(string message)
	{
		Debug.Log(message);
	}

	public void LogMovable(Character character)
	{
		Vector2 movement = character.GetInputMovement();
		Log(character.name + " " + movement.ToString());
		//character.FillAmmunition(5); // ya slomal charactera, haha
	}

	public void LogCollection(IEnumerable collection)
	{
		foreach (var item in collection)
		{
			Debug.Log(item.ToString());
		}
	}
}
public class LoggerWrapper : MonoBehaviour
{
    private UnityLogger logger;

    public UnityLogger Logger => logger;

    private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Z))
        {

            List<string> stringsList = new List<string>() { "STR", "StringTwo", "StringThree" };
            string[] stringsArray = new string[] { "STRARR", "StringArrTwo" };
            IEnumerable<string> onlyUpperCase = stringsList.Where(str => str.All(ch => char.IsUpper(ch))); // выбираем те строки, где символы в upperCase

			Logger.LogCollection(stringsList);
			Logger.LogCollection(stringsArray);
			Logger.LogCollection(onlyUpperCase);
		}
    }	
}
