using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class test : MonoBehaviour {

    public InputField mainInputField;
    public static string elem;


    public void Start()
    {
        mainInputField.onEndEdit.AddListener(delegate {  elem = mainInputField.text; print(elem); });

    }
    public void LoadOnClick()
    {
        SceneManager.LoadScene("game_planet", LoadSceneMode.Single);
    }
}
