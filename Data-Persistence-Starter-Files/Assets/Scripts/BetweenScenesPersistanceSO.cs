using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "BetweenScenesPersistanceSO", menuName = "ScriptableObjects/BetweenScenesPersistanceSO")]

public class BetweenScenesPersistanceSO : ScriptableObject
{
    public string playerName = "";
    [SerializeField] GameObject startPanelPrefab;
 
    private GameObject startPanel;
    private InputField inputField = null;

    public void Initialize(GameObject mainCanvas)
    {
        startPanel = Instantiate(startPanelPrefab, mainCanvas.transform);
        inputField = null;
        Transform inputFieldTransform = startPanel.transform.Find("InputField");
        if (inputFieldTransform != null)
        {
            inputField = inputFieldTransform.gameObject.GetComponent<InputField>();
        }
    }

    public void OnPlayButtonPressed()
    {
        if (inputField != null)
        {
            playerName = inputField.text;
        }
        SceneManager.LoadScene(1);
    }
}
