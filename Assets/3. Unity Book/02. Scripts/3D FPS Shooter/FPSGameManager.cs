using TMPro;
using UnityEngine;

public class FPSGameManager : Singleton<FPSGameManager>
{
    public enum GameState { Ready, Run, GameOver }
    public GameState gState;

    public GameObject gameLabel;
    private TextMeshProUGUI gameText;

    void Start()
    {
        gState = GameState.Ready;
        gameText = gameLabel.GetComponent<TextMeshProUGUI>();

        gameText.text = "Ready...";
        gameText.color = new Color32(255, 185, 0, 255);
    }
}