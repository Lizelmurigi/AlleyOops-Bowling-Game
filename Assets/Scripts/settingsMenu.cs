using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsMenu : MonoBehaviour
{
    [SerializeField] Slider Slider;
    // Start is called before the first frame update
    void Start()
    {
       
        if(!PlayerPrefs.HasKey("musicVolume"))

        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else
        {
            Load();
        }

    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = Slider.value;
        Save();
    }
    private void Load()
    {
        Slider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", Slider.value);
    }
}
