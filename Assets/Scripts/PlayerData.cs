using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    public PlayerData (Player player)
    {
        level = player.level;
    }	
}
