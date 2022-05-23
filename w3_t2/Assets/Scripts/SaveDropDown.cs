using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SaveDropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    List<string> graphicOptionList = new List<string> { "Low", "Medium", "High" };

    private void Start()
    {
        dropdown.value = PlayerPrefs.GetInt("dropdown_list");
    }

    public void SaveData(string value)
    {
        graphicOptionList.Equals(value);
        PlayerPrefs.SetInt("dropdown_list", dropdown.value);
    }
}
