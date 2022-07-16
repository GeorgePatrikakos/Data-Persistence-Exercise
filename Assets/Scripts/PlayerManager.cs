using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static int highScore;
    private static string highPlayer;
    private static string lastPlayer;

    public static int HighScore { get => highScore; set => highScore = value; }
    public static string HighPlayer { get => highPlayer; set => highPlayer = value; }
    public static string LastPlayer { get => lastPlayer; set => lastPlayer = value; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        FileStream file;
        string savePath = Application.persistentDataPath + "/save.dat";
        if (File.Exists(savePath)) file = File.OpenRead(savePath);
        else return;

        BinaryFormatter bf = new BinaryFormatter();
        string[] data = (string[])bf.Deserialize(file);
        file.Close();

        int.TryParse(data[0], out highScore);
        HighPlayer = data[1];
    }
}