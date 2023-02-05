using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    private SubGameController subController;

    

    public SubGameController.ItemType itemType = SubGameController.ItemType.None;

    public float itemValue = 0;
   

    private void Awake()
    {
        if (subController == null)
            subController = SubGameController.instance;

    }

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I'm triggering");
        subController.CollectItem(collision, itemType, itemValue);
        gameObject.SetActive(false);
    }
   
}
