using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Project
{
public class Gameplay_GameState : GameStateBase
{
    public override void Enter()
        {
            SceneManager.LoadSceneAsync(2).completed += (operation) =>
            {
                Button startButton = Object.FindObjectOfType<Button>();
                startButton.onClick.AddListener(() =>
                {
                    _gameStateChanger.ChangeState(new MainMenu_GameState());
                });
            };
        }
}
}