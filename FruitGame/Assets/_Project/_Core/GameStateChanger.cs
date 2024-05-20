using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project
{
    public enum DayType { Normal, Halloween, NewYear}

public class GameStateChanger : MonoBehaviour
{
    public DayType dayType = DayType.Normal;

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
