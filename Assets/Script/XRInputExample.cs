using UnityEngine;
using UnityEngine.XR;

public class XRInputExample : MonoBehaviour
{
    public int textNum;
    public bool wasButtonPressed = false;
    void Update()
    {
        // ボタンの入力を取得
        bool isButtonPressed = CheckButtonInput();

        // ボタンが押されたら変数aを増加させる
        if (isButtonPressed && !wasButtonPressed)
        {
            textNum += 1; // Time.deltaTimeを使ってフレームレートに依存しないようにする
            Vector3 pos = transform.position;
            pos.x = 0;
            pos.y = 0.6f;
            pos.z = 1.56f;
            transform.position = pos;
            Debug.Log("Button Pressed! a = " + textNum);
        }
        wasButtonPressed = isButtonPressed;
    }

    public bool CheckButtonInput()
    {
        // OpenXRを使用してボタンの入力を取得する
        // ここでは例としてPrimaryButton（具体的なボタンはプロジェクトの設定に依存します）の状態を確認しています。
        // OpenXR APIの具体的な使用方法はプラグインのドキュメントやOpenXRのドキュメントを参照してください。
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand); // 右手のデバイスを仮定
        bool isButtonPressed = false;
        if (device.TryGetFeatureValue(CommonUsages.primaryButton, out isButtonPressed) && isButtonPressed)
        {
            return true;
        }
        return false;
    }
}