using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyManager : MonoBehaviour
{
    public Text money_text;

    private void Update()
    {
        money_text.text = "$" + SaveManager.Instance.state.money;
    }
}
