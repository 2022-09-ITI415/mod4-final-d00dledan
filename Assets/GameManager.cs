using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject youWinText;
    public float resetDelay;

    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Destroy(gameObject);
        } 
    }

    public void Win()
    {
        youWinText.SetActive(true);
        Time.timeScale = .25f;
        Invoke("Reset", resetDelay);
    }

     void Reset()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("TerrainScene");
    }
}
