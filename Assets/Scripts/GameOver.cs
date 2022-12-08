using UnityEngine;
using UnityEngine.Tilemaps;

public class GameOver : MonoBehaviour
{   
    [SerializeField] Board board;
    [SerializeField] PauseResume pauseResume;

    public GameObject GameOverScreen;

    public void GoToGameOverScreen()
    {
        pauseResume.PauseGameOver();
        GameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        pauseResume.ResumeGameOver();
        GameOverScreen.SetActive(false);
        board.tilemap.ClearAllTiles();
        board.Start();
    }
}