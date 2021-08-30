using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   
   public static void SavePlayer(Score_Text score_Text)
   {
       BinaryFormatter formatter = new BinaryFormatter();

       string path = Application.persistentDataPath + "/player.fun"; // where will the data be saved
       FileStream stream = new FileStream(path, FileMode.Create);

       PlayerData data = new PlayerData(score_Text);

       formatter.Serialize(stream, data);
       stream.Close();
   }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun"; // where will the data be saved

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream =  new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
