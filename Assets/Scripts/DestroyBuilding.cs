using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyBuilding : MonoBehaviour
{
    Land targetLand;

    public void CheckStatus(Land land)
    {
        targetLand = land;
        if (targetLand.GetLandBuilding() != null)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
        Debug.Log(targetLand.GetLandBuilding());

    }

    public void RunDestroy()
    {
        targetLand.SetLandBuilding(null);
        targetLand.GetComponentInChildren<Text>().text = targetLand.GetLandId();
        targetLand.bigMapLand.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
