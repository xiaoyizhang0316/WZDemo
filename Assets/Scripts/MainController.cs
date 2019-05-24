using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    bool state = true;
    [SerializeField] string panelType;


    public void ToggleShow()
    {

        gameObject.SetActive(!state);
        state = !state;
    }
    // Start is called before the first frame update

    void Start()
    {
        state = true;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
