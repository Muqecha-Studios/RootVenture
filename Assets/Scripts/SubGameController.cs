using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubGameController : MonoBehaviour
{
    public static SubGameController instance;

    public enum ItemType
    {
        None,
        Water,
        Iron,
        Potassium,
    }

    public List<GameObject> collectable_water;
    public TMP_Text staminaTxt;
    public TMP_Text timeTxt;
    

    public float timeRemaining = 60;
    public float stamina = 50;


    public float waterQty = 0f;
    public float potassiumQty = 0;
    public float ironQty = 0;


    public TMP_Text waterQtyText;
    public TMP_Text ironQtyText;
    public TMP_Text potassiumQtyText;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            int time = (int)timeRemaining;
            timeTxt.GetComponent<TextMeshProUGUI>().text  = time.ToString();
        }
    }
   
    public void CollectItem(ItemType type, float value)
    {
            switch (type)
            {
                case ItemType.None: 
                    return;
                case ItemType.Water:
                    waterQty += value;
                    Debug.Log(waterQty);
                    waterQtyText.text = waterQty.ToString();
                    return;
                case ItemType.Potassium:
                    potassiumQty += value;
                    potassiumQtyText.text = potassiumQty.ToString();
                    return;
                case ItemType.Iron:
                    ironQty += value;
                    ironQtyText.text = ironQty.ToString();
                    return;
            }
    }
}
