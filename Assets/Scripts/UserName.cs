using UnityEngine;

public class UserName : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public string PlayerName { get; set; }
}
