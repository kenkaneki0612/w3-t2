using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveDropDownLanguge : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    List<string> graphicOptionList = new List<string> { "Japanese", "Vietnamese", "English" };

    private void Start()
    {
        dropdown.value = PlayerPrefs.GetInt("dropdown_list_language");
    }

    public void SaveData(string value)
    {
        graphicOptionList.Equals(value);
        PlayerPrefs.SetInt("dropdown_list_language", dropdown.value);
    }
}
