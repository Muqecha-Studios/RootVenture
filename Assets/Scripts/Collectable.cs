using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    
    // Start is called before the first frame update
    public TextMeshProUGUI staminaTxt, waterTxt,potassiumTxt, ironTxt, timeTxt;
    int stamina = 50;
    int water = 0;
    int potassium = 0;
    int iron = 0;

    private void Awake()
    {
        water = int.Parse(waterTxt.text);
    }

    void Start()
    {
        waterTxt.GetComponent<TextMeshProUGUI>().text  = water.ToString();
        // potassiumTxt.GetComponent<TextMeshProUGUI>().text  = potassium.ToString();
        // ironTxt.GetComponent<TextMeshProUGUI>().text  = iron.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        water = int.Parse(waterTxt.text);
    }




     void OnTriggerEnter2D(Collider2D collision)
    {
        
        //Debug.Log("Do something here");
        if (collision.gameObject.name == "collider")
        {
            Destroy(this.gameObject);
            water++;
            waterTxt.text = water.ToString();
             Debug.Log(water);
            
          
           
        }
        if (collision.gameObject.name == "floor")
        {
            Debug.Log("floor");
        }

       
    }
   
}
