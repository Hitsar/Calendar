using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]

public class PlayerInfo
{
    public float Time;
}

public class Progress : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    public PlayerInfo PlayerInfo;

    [DllImport("__Internal")]
    private static extern void SaveExtern(string date);
    [DllImport("__Internal")]
    private static extern void LoadExtern();

    public static Progress Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadExtern();
    }

    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
    }

    public void MuteAudio() => _audio.mute = true;
    public void PlayAudio() => _audio.mute = false;
}