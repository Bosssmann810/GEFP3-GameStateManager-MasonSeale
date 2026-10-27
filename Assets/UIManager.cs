using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject mainMenuUi;
    public GameObject gameplayUi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void UpdateUI()
    {
        pauseUI.SetActive(false);
        mainMenuUi.SetActive(false);
        gameplayUi.SetActive(false);
    }
    public void ShowMainMenu()
    {
        UpdateUI();
        mainMenuUi.SetActive(true);
    }

    public void ShowGameplay()
    {
        UpdateUI();
        gameplayUi.SetActive(true);
    }

    public void ShowPauseUI()
    {
        UpdateUI();
        gameplayUi.SetActive(true);
        pauseUI.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
