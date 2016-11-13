using UnityEngine;
using GameProgramming2D.GUI;
using System.Collections;

namespace GameProgramming2D
{



    public class Pauser : MonoBehaviour
    {
        private bool paused = false;
        private Dialog _pauseDialog;

        public bool isPaused { get { return paused; } }

        public void SetPauseOn()
        {
            Time.timeScale = 0;
            if (_pauseDialog == null)
            {
                _pauseDialog = GameManager.Instance.GUIManager.CreateDialog();
                _pauseDialog.SetHeadLine("Pause");
                _pauseDialog.SetText("The game is paused. Press continue to continue game");
                _pauseDialog.SetShowCancel(false);
                _pauseDialog.SetOkButtonText("Continue");
                _pauseDialog.SetOnOkClicked(ContinueGame);
            }


            _pauseDialog.Show();
        }

        public void ContinueGame()
        {
            Time.timeScale = 1;
            Debug.Log("Continue Game");
        }

        public void TogglePause()
        {
            paused = !paused;

            if (paused)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }
}