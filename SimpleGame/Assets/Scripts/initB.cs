
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class initB : MonoBehaviour
{

    public GameObject cubePrefab;
    public Material[] material;
    Renderer rend;

    public Text Display;
    public int count = 0;
    // Use this for initialization
    void Start()
    {
        Display.GetComponent<Text>().enabled = false;
        string elements = test.elem;
        int N = int.Parse(elements);
        for (int i = 0; i < N - 1; i++)//n-1
        {
           
            Vector3 position = new Vector3(Random.Range(-8.0F, 8.0F), Random.Range(-3.0F, 3.0F), 0);
            Instantiate(cubePrefab, position, Quaternion.identity).transform.Rotate(Vector3.forward * Random.Range(0.1F, 3.0F));
            cubePrefab.gameObject.transform.localScale = new Vector3(Random.Range(0.1F, 3.0F), Random.Range(0.1F, 3.0F), 0);

            rend = cubePrefab.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material[Random.Range(0, 7)];
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindObjectsOfType(typeof(planet)).Length == 0 && count < 1)//zmiana na 0
        {

            float time2 = Time.time;
            Display.GetComponent<Text>().enabled = true;
            Display.text = " You win!\n Your time: " + time2 + "s";
            count = 1;
        }
    }

}


