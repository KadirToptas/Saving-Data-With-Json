using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CharacterManager : MonoBehaviour
{
    public Characters characters;


    private void Awake()
    {
        LoadCharacterData();
    }

[ContextMenu("Update")]
    public void UpdateCharacter()
    {
        characters.characterDatas[0].Name = "Alp";
        characters.characterDatas[0].Element = "Tahta";
        characters.characterDatas[0].Damage = 10f;
        characters.characterDatas[0].Health = 150f;
        Save();

    }


    #region Save&Load

    private void LoadCharacterData()
    {
        if (File.Exists(Application.persistentDataPath + "/CharacterData.json"))
        {
            Load();
        }
    }
    
    [ContextMenu("Save")]
    public void Save()
    {
        string json = JsonUtility.ToJson(characters, true);
        File.WriteAllText(Application.persistentDataPath + "/CharacterData.json",json);
    }



    public void Load()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/CharacterData.json");
        characters = JsonUtility.FromJson<Characters>(json);
    }

    #endregion
}



[System.Serializable]

public class Characters
{
    public List<CharacterData> characterDatas = new List<CharacterData>();
}
