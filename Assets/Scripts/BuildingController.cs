using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{

    [SerializeField] string panelType;
    bool state;

    public void ToggleShow()
    {
        gameObject.SetActive(!state);
        state = !state;
    }


    // Start is called before the first frame update
    void Start()
    {
        state = false;
        gameObject.SetActive(state);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
