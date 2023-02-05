using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubGameController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject[] collectable_water;
    public List<GameObject> collectable_water;
    public TextMeshProUGUI staminaTxt, waterTxt,potassiumTxt, ironTxt, timeTxt;
    int stamina = 50;
    public int water = 5;
    int potassium = 0;
    int iron = 0;

    public float timeRemaining = 60;
    void Start()
    {
        // staminaTxt.GetComponent<TextMeshProUGUI>().text  = stamina.ToString();
        waterTxt.GetComponent<TextMeshProUGUI>().text  = water.ToString();
        // potassiumTxt.GetComponent<TextMeshProUGUI>().text  = potassium.ToString();
        // ironTxt.GetComponent<TextMeshProUGUI>().text  = iron.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            int time = (int)timeRemaining;
            timeTxt.GetComponent<TextMeshProUGUI>().text  = time.ToString();
        }
    }
   

   
    void collectwater()
    {
        updateScore(1,0,0,0,0);
    }
    void collectiron()
    {
        updateScore(0,1,0,0,0);
    }
    void collectpot()
    {
        updateScore(0,0,1,0,0);
    }
    void punch()
    {
        updateScore(0,0,0,1,0);
    }
    void pest()
    {
        updateScore(0,0,0,0,1);
    }

    void updateScore(int wt,int ir, int pt,int punch, int pest)
    {
        int s = wt + (10*ir) + (5*pt) - (10*punch) - (20*pest);
        stamina+=s;
        water+=wt;
        iron+=ir;
        potassium+=pt;
    
        // staminaTxt.GetComponent<TextMeshProUGUI>().text  = stamina.ToString();
        waterTxt.GetComponent<TextMeshProUGUI>().text  = water.ToString();
        // potassiumTxt.GetComponent<TextMeshProUGUI>().text  = potassium.ToString();
        // ironTxt.GetComponent<TextMeshProUGUI>().text  = iron.ToString();
    }
}
