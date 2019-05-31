using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] Land[] landList;
    private Hashtable resourceList;

    public void setLandList(Land[] land)
    {
        landList = land;
    }

    public Land[] getLandList()
    {
        return landList;
    }

    public void InitializeResource()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        InitializeResource();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
