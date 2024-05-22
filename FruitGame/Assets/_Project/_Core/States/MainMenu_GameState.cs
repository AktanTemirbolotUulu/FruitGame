using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using SO;

namespace Project
{
    public class MainMenu_GameState : GameStateBase
    {
        private UIContainer _uiContainer;
        private UIBase _mainMenu;
        private Button _playButton;
        private Button _shopButton;
        public override void Enter()
        {
            _uiContainer = Resources.Load<UIContainer>
            ("Configurations/UIContainer_" + _gameStateChanger.dayType.ToString());

            SceneManager.LoadSceneAsync(1).completed += (operation) =>
            {
                UIBase mainMenuPrefab = _uiContainer.GetUI("MainMenu");
                _mainMenu = Object.Instantiate(mainMenuPrefab);

                _playButton = _mainMenu.transform.Find("PlayButton").GetComponent<Button>();
                _playButton.onClick.AddListener(GoToGampleay);

                _shopButton = _mainMenu.transform.Find("ShopButton").GetComponent<Button>();
                _shopButton.onClick.AddListener(GoToShop);


            };
        }
        private void GoToGampleay()
            {
                _gameStateChanger.ChangeState(new Gameplay_GameState());
            }

        private void GoToShop()
            {
                _gameStateChanger.ChangeState(new Shop_GameState());
            }
    }
}

