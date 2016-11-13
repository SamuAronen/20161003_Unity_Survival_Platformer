using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace GameProgramming2D.GUI
{
    public class MainMenuGUI : SceneGUI

    {
        [SerializeField] private Button _loadButton;

        protected void Awake()
        {
            _loadButton.interactable = SaveSystem.DoesSaveExist();
        }

        public void OnStartGamePressed()
        {
            GameManager.Instance.StateManager.PerformTransition(State.TransitionType.MainMenuToGame);
        }

        public void OnLoadGamePressed()
        {
            GameManager.Instance.LoadGame();
        }

        public void OnExitGamePressed()
        {
            Application.Quit();
        }
    }
}