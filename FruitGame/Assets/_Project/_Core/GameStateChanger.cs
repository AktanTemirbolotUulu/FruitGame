using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project
{
public class GameStateChanger : MonoBehaviour
{
    private GameStateBase _currentState;
    private void Start()
    {
        ChangeState(new MainMenu_GameState());
    }
    public void ChangeState(GameStateBase newGameStateBase)
    {
        _currentState?.Exit();

        _currentState = newGameStateBase;
        _currentState.SetGameStateChanger(this);
        _currentState?.Enter();
    }
}
}
