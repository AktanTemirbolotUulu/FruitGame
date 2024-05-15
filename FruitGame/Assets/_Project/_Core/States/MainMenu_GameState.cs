using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Project
{
    public class MainMenu_GameState : GameStateBase
    {
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(1).completed += (operation) =>
            {
                Button startButton = Object.FindObjectOfType<Button>();
                startButton.onClick.AddListener(() =>
                {
                    _gameStateChanger.ChangeState(new Gameplay_GameState());
                });
            };
        }

    }

}