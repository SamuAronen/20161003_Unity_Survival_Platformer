using UnityEngine;
using System.Collections;

namespace GameProgramming2D.GUI
{
    public class MainMenuGUI : MonoBehaviour
    {
        public void OnStartGamePressed()
        {
            GameManager.Instance.StateManager.PerfomrmTransition(State.TransitionType.MainMenuToGame);
        }
        

        public void OnExitGamePressed()
        {
            Application.Quit();
        }
    }
}