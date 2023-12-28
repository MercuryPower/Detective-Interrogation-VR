using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public TipsScript textAnimation;

    public void OnButtonClick()
    {
        textAnimation.StartAnimation();
    }
}
