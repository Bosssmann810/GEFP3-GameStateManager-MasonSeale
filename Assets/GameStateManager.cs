using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum state
    {
        None, Init, Menu, Game, Pause,
    }
    public UIManager uiManager;
    public state currentState { get; private set; }
    public state previousState { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetState(state.Init);
    }

    public void SetState(state newState)
    {
        if (currentState == newState) return;
        previousState = currentState;
        currentState = newState;
        OnGameStateChanged(previousState, currentState);
    }

    public void PauseGame()
    {
        SetState(state.Pause);
    }
    public void MainMenu()
    {
        SetState(state.Menu);
    }
    public void StartGame()
    {
        SetState(state.Game);
    }
    private void OnGameStateChanged(state previousState, state newState)
    {
        switch (newState)
        {
            case state.None:
                break;
            case state.Init:
                SetState(state.Menu); break;
            case state.Menu:
                Time.timeScale = 1f;
                uiManager.ShowMainMenu();
                break;
            case state.Pause:
                Time.timeScale = 0f;
                uiManager.ShowPauseUI();
                break;
            case state.Game:
                Time.timeScale = 1f;
                uiManager.ShowGameplay();
                break;
        }
    }
}