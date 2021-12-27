using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SavePatung : MonoBehaviour
{
    public static SavePatung patungSave;
    public List<ScriptableObject> objects = new List<ScriptableObject>();
    private void Awake()
    {
        if(patungSave == null)
        {
            patungSave = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }
    /* void OnEnable()
    {
        LoadScriptable();
    }
    private void OnDisable()
    {
        SaveScriptable();
    }
    public void SaveScriptable()
    {
        for(int i = 0; i < objects.Count; i++)
        {
            FileStream file = File.Create(Application.persistentDataPath +
                string.Format("/{0}.dat", i));
            BinaryFormatter binary = new BinaryFormatter();
            var json = JsonUtility.ToJson(objects[i]);
            binary.Serialize(file, json);
            file.Close();
        }
    }
    public void LoadScriptable()
    {
        for(int i = 0; i <objects.Count; i++)
        {
            if (File.Exists(Application.persistentDataPath +
                string.Format("/{0}.dat", i)))
            {
                FileStream file = File.Open(Application.persistentDataPath +
                string.Format("/{0}.dat", i), FileMode.Open);
                BinaryFormatter binary = new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file),objects[i]);
                file.Close();
            }
        }
    }
    */
}
