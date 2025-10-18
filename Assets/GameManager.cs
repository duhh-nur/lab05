using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] levels;
    public GameObject[] cars;


    // Start is called before the first frame update
    void Start()
    {
        
        cars[PlayerPrefs.GetInt("selectedcar")].SetActive(true);
        levels[PlayerPrefs.GetInt("selectLevel")-1].SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
