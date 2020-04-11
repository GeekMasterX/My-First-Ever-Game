using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    public Text scoreTxt;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void ScoreUp()
    {
        score++;
        scoreTxt.text = score.ToString();
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreTxt.gameObject.SetActive(true);
    }

    
}
