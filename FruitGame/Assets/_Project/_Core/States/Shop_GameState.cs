using System.Collections;
using System.Collections.Generic;
using SO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Project
{
public class Shop_GameState : GameStateBase
{
    private UIContainer _uiContainer;
    private Button _backButton;
    private UIBase _shopUI;
    public override void Enter()
        {
            _uiContainer = Resources.Load<UIContainer>
            ("Configurations/UIContainer_" + _gameStateChanger.dayType.ToString());

            SceneManager.LoadSceneAsync(3).completed += (_) =>
            {
                _shopUI = Object.Instantiate(_uiContainer.GetUI("Shop"));

                _backButton = _shopUI.transform.Find("BackButton").GetComponent<Button>();
                _backButton.onClick.AddListener(GoBack);
            };
        }
        private void GoBack()
            {
                _gameStateChanger.ChangeState(new MainMenu_GameState());
            }
}
}
