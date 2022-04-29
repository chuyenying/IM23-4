using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class AutoTurn : MonoBehaviour
{
    public string currentText = "但是...這個地方...";
    public float rotateSpeed = 10.0f;

    public bool IsCorrect(string requiredText)
    {
        return currentText == requiredText;
    }

    public void Turn(bool T1)
    {
        if (T1 == true)
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
    }

    #region Register with Lua
    private void OnEnable()
    {
        Lua.RegisterFunction("IsCorrect", this, SymbolExtensions.GetMethodInfo(() => IsCorrect(string.Empty)));
        Lua.RegisterFunction("Turn", this, SymbolExtensions.GetMethodInfo(() => Turn((bool)false)));
    }

    private void OnDisable()
    {
        Lua.UnregisterFunction("IsCorrect");
        Lua.UnregisterFunction("Turn");
    }
    #endregion
}
