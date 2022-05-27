using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance{set; get; }
    public SaveState state;

    private void Awake()
    {
        //ResetSave();
        DontDestroyOnLoad(gameObject);
        Instance = this;//to make sure w do have our instance
        Load();
        Debug.Log(Helper.Serialize<SaveState>(state));
    }
    //save the whole state of this SaveState script to the PlayerPrefs
    public void Save()
    {
        PlayerPrefs.SetString("save", Helper.Serialize<SaveState>(state));//we convert our SaveState class (serialize it) to a string "save"

    }
    //this func load the previous saved state from the PlayerPrefs
    public void Load()
    {
        //checking if we already have a save
        if(PlayerPrefs.HasKey("save"))
        {
            // this mean to convert back our "save" string to an actual class;
            state = Helper.Deserialize<SaveState>(PlayerPrefs.GetString("save"));
        }
        else//in the case where we never save 
        {
           state = new SaveState();// we create a new Savestate
           Save();//we save
           Debug.Log("no save file found, creating a new one");
        }
    }
    public void ResetSave()
    {
        PlayerPrefs.DeleteKey("save");
    }
    //now we are going to create a script call helper that are going to serialize our savestate(convert our SaveState class to a string)
    //and also  deserialize it.
}
