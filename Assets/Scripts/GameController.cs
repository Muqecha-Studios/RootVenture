using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int SceneCode;
    private int nextSceneIndex;

    public Button playBtn;
    public Button pauseBtn;
    public Button mainMenuBtn;
    public Button mainMenuBtn2;
    public Button nextLevelBtn;

    public RectTransform pausePanel;
    public RectTransform winPanel;

    public List<float> levelGoal;
   
    private void Awake()
    {
        SceneCode = SceneManager.GetActiveScene().buildIndex;

        pausePanel.gameObject.SetActive(false);
        winPanel.gameObject.SetActive(false);

        playBtn.onClick.AddListener(ResumeGame);
        pauseBtn.onClick.AddListener(PauseGame);
        mainMenuBtn.onClick.AddListener(ReturnToMainMenu);
        mainMenuBtn2.onClick.AddListener(ReturnToMainMenu);
        nextLevelBtn.onClick.AddListener(LoadNextlevel);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        CheckIfWon();
    }

    // Update is called once per frame

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        pausePanel.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        pausePanel.gameObject.SetActive(false);
    }

    public void LoadNextlevel()
    {
        SceneManager.LoadScene(++SceneCode);
    }

    public void CheckIfWon()
    {
        if (levelGoal == null) return;

        if (levelGoal[0].ToString() == SubGameController.instance.waterQtyText.text && 
            levelGoal[1].ToString() == SubGameController.instance.potassiumQtyText.text && 
            levelGoal[2].ToString() == SubGameController.instance.ironQtyText.text)
        {
            winPanel.gameObject.SetActive(true);
        }
    }


}
