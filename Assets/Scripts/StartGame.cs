using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_InputField field;

    public void Begin()
    {
        PlayerManager.LastPlayer = field.text;
        SceneManager.LoadScene("main");
    }
}
