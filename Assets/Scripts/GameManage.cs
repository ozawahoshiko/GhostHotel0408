using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public static GameManage instance;
    [SerializeField] private string loadScene;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;
    public int stagecounter = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    string[] stages = { "Scene1", "Scene2", "Scene3", "Scene4", "Scene5", "Scene6",
    "Scene7","Scene8"};

    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
    {
        Initiate.Fade(sceneName, fadeColor, fadeSpeedMultiplier);
    }

  
  
    public string SetNextStage()
    {
        stagecounter++;
        return stages[stagecounter];
    }
    public void GoNextScene()
    {
        Initiate.Fade(SetNextStage(), fadeColor, fadeSpeedMultiplier);
    }

    public void GoStageSelect()
    {
        Initiate.Fade("stageSelect", fadeColor, fadeSpeedMultiplier);
    }
    public void GoMenu()
    {
        Initiate.Fade("Menu", fadeColor, fadeSpeedMultiplier);
    }

}
