using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class StartGame : MonoBehaviour
{

    [SerializeField] private TMP_InputField userNameInputField;
    [SerializeField] private UserName userName;

    public void LoadGame()
    {
        if (string.IsNullOrEmpty(userNameInputField.text))
        {
            Debug.LogError("We need user name!");
            return;
        }
        userName.PlayerName = userNameInputField.text;
        SceneManager.LoadScene(1);
    }

}
