using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    public SubGameController.ItemType itemType = SubGameController.ItemType.None;

    public float itemValue = 0;

    private void Awake()
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SubGameController.instance.CollectItem(itemType, itemValue);
        gameObject.SetActive(false);
    }
   
}
