using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public Image m_Image,m_Image2;
    public Sprite m_Sprite1,m_Sprite2,m_Sprite3;
    public TextMeshProUGUI charName;
    void Start()
    {
         //m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectChar(string character)
    {
        charName.GetComponent<TextMeshProUGUI>().text = character;
        switch(character)
        {
            case "carrot":
            m_Image.sprite = m_Sprite1;
            m_Image2.sprite = m_Sprite1;
            break;
            case "tomato":
            m_Image.sprite = m_Sprite2;
            m_Image2.sprite = m_Sprite2;
            break;
            case "potato":
            m_Image.sprite = m_Sprite3;
            m_Image2.sprite = m_Sprite3;
             break;
        }
       
    }

    public void launchGame()
    {
         SceneManager.LoadScene("CharacterSelector");
    } 
}
