using UnityEngine.SceneManagement;

namespace GameProgramming2D.State
{
    class GameOverState : StateBase
    {
        public GameOverState() : base()
        {
            State = StateType.GameOver;
            AddTransition(TransitionType.GameOverToGame, StateType.Game);
            AddTransition(TransitionType.GameOverToMenu, StateType.MainMenu);
        }

        public override void StateActivated()
        {
            SceneManager.LoadScene(2);
        }
    }
}
