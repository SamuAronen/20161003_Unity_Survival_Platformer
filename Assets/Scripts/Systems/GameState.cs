using UnityEngine.SceneManagement;

namespace GameProgramming2D.State
{
    class GameState : StateBase
    {
        public GameState()
        {
            State = StateType.Game;
            AddTransition(TransitionType.GameToGameOver, StateType.GameOver);
        }
        public override void StateActivated()
        {
            SceneManager.LoadScene(1);
        }
    }
}
