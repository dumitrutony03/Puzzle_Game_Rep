using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    // both of 'em have different files
    // where are saved

   // Coins and Rubys throught the game
   /*public static void SavePlayer(Score_Text score_Text)
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

   // SpriteColor from shop to the game
   public static void SavePlayer_SpriteColor(Button_CharacterGetsSkin button_CharacterGetsSkin)
   {
       BinaryFormatter formatter = new BinaryFormatter();

       string path = Application.persistentDataPath + "/player1.fun"; // where will the data be saved
       FileStream stream = new FileStream(path, FileMode.Create);

       PlayerData_SpriteColor data_SpriteColor = new PlayerData_SpriteColor(button_CharacterGetsSkin);

       formatter.Serialize(stream, data_SpriteColor);
       stream.Close();
   }
    public static PlayerData_SpriteColor LoadPlayer_SpriteColor()
    {
        string path = Application.persistentDataPath + "/player1.fun"; // where will the data be saved

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream =  new FileStream(path, FileMode.Open);

            PlayerData_SpriteColor data_SpriteColor = formatter.Deserialize(stream) as PlayerData_SpriteColor;
            stream.Close();

            return data_SpriteColor;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }*/
}
