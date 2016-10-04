using UnityEngine;
using System.Collections;
using GameProgramming2D;

namespace GameProgramming2D.GUI
{
    public class GameOverGUI : MonoBehaviour
    {
        public void OnRestartGamePressed()
        {
            GameManager.Instance.StateManager.PerformTransition(State.TransitionType.GameOverToGame);
        }


        public void OnMainMenuPressed()
        {
            GameManager.Instance.StateManager.PerformTransition(State.TransitionType.GameOverToMenu);
        }
    }
}