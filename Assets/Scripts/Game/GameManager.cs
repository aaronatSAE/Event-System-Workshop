using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, InGame, GameOver }
    public static GameState currentState = GameState.MainMenu;

    float fireSpawnTimer = 0.5f;
    public static int firesPutOut = 0;

    void Update()
    {
        switch (currentState)
        {
            case GameState.MainMenu:
                break;
            case GameState.InGame:
                fireSpawnTimer -= Time.deltaTime;
                if (fireSpawnTimer <= 0f)
                {
                    fireSpawnTimer = Random.Range(0f, 0.5f);
                    EventManager.MethodSpawnFire();
                }

                if (WaterGun.waterLeft <= 0f)
                {
                    currentState = GameState.GameOver;
                    return;
                }
                break;
            case GameState.GameOver:
                break;
        }
    }

    private void OnGUI()
    {
        switch (currentState)
        {
            case GameState.MainMenu:
                GUILayout.BeginArea(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 50, 400, 100));
                GUILayout.BeginVertical();
                GUILayout.Box("It's bushfire season and you only have 30L of water left.\nMan the firehose and put out as many fires as you can!");
                if (GUILayout.Button("Click to start"))
                {
                    StartGame();
                }
                GUILayout.EndVertical();
                GUILayout.EndArea();
                break;
            case GameState.InGame:
                GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, 10, 200, 70));
                GUILayout.BeginVertical();
                GUILayout.Box("Water left: " + (int)WaterGun.waterLeft + "L");
                GUILayout.Box("Fires put out: " + firesPutOut);
                GUILayout.EndVertical();
                GUILayout.EndArea();
                break;
            case GameState.GameOver:
                GUILayout.BeginArea(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 50, 400, 100));
                GUILayout.BeginVertical();
                GUILayout.Box("Game over!\n You put out " + firesPutOut + " fires. Good work!");
                if (GUILayout.Button("Click to play again"))
                {
                    StartGame();
                }
                GUILayout.EndVertical();
                GUILayout.EndArea();
                break;
        }
    }

    void StartGame()
    {
        WaterGun.waterLeft = 30f;
        firesPutOut = 0;
        currentState = GameState.InGame;
    }
}
