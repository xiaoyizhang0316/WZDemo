using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLand : MonoBehaviour
{

    [SerializeField] Land playerLand;
    private Building playerBuilding;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
