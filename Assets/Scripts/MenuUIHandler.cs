using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI BestScoreText;
    [SerializeField] private TMP_InputField nameInput;
    private void Start()
    {
        BestScoreText.text = "Best Score : " + DataPersistence.Instance.bestPlayer 
            + " : " + DataPersistence.Instance.bestScore;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void NameInputField()
    {
        DataPersistence.Instance.currPlayerName = nameInput.text;
    }

    public void Exit()
    {
        DataPersistence.Instance.SaveScoreInfo();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
