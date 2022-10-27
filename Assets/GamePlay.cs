using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    //public Text levelName
    public GameObject levelPrefab;
    private void Start()
    {
        int index = PlayerPrefs.GetInt("levelSelected");
        //levelName.text = "Level " + index.ToString();
        levelPrefab = Resources.Load<GameObject>("Level" + index);
        Instantiate(levelPrefab);
    }

   
}
