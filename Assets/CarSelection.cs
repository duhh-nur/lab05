using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    public GameObject[] cars;
    public GameObject[] levels;
    int currentIndex = 0;
    public GameObject levelSelection;
    public GameObject carSelectionPanel;
    int currentlevel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextCar()
    {
        cars[currentIndex].SetActive(false);
        currentIndex++;

        if (currentIndex > cars.Length - 1)
        {
            currentIndex = 0;
        }
        cars[currentIndex].SetActive(true);
       
        
    }

    public void PrevCar()
    {
        cars[currentIndex].SetActive(false);
        currentIndex--;

        if (currentIndex < 0) 
        {
            currentIndex = cars.Length-1;
        }

       
        cars[currentIndex].SetActive(true);
  
    }

    public void carselect()
    {
        PlayerPrefs.SetInt("selectedcar", currentIndex);
        levelSelection.SetActive(true);
        carSelectionPanel.SetActive(false);

    }

    public void levelSelect(int a)
    {
       
        PlayerPrefs.SetInt("selectLevel", a);
        SceneManager.LoadScene("levels");
    }

}
