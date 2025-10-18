using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject carselectionpanel;
    public GameObject mainmenupanel;

    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayClick()
    {
        car.SetActive(true);
        carselectionpanel.SetActive(true);
        mainmenupanel.SetActive(false);
    }
}
