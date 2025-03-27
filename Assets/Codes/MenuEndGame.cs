using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEndGame : MonoBehaviour
{
    public GameObject MenuGame;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newGame()
    {
        SceneManager.LoadScene("");
    }

    public void restartGame()
    {
        SceneManager.LoadScene("");
    }

    public void GetMenu()
    {
        MenuGame.SetActive(true);
    }
    
    
}
