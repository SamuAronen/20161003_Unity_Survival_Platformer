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
            GameManager.Instance.SceneLoaded += HandleSceneLoaded;
            SceneManager.LoadScene(1);
        }
    }
}
