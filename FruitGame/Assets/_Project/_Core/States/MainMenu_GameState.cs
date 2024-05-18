using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project
{
    public class MainMenu_GameState : GameStateBase
    {
        private UIBase _mainMenu;
        private Button _playButton;
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(1).completed += (operation) =>
            {
                //UIBase mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenu" + _gameStateChanger.dayType.ToString());
                UIBase mainMenuPrefab = null;
                if(_gameStateChanger.dayType == DayType.Usual)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenu");
                }
                else if (_gameStateChanger.dayType == DayType.Halloween)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenu_Halloween");
                }
                else if (_gameStateChanger.dayType == DayType.NewYear)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenu_NewYear");
                }
                _mainMenu = Object.Instantiate(mainMenuPrefab);

                _playButton = _mainMenu.GetComponentInChildren<Button>();
                _playButton.onClick.AddListener(GoToGampleay);
            };
        }
        private void GoToGampleay()
            {
                _gameStateChanger.ChangeState(new Gameplay_GameState());
            }
    }
}

