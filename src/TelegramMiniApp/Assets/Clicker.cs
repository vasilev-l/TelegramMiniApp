using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public Button Button;
    public RectTransform ButtonRectTransform;
    public RectTransform WindowRectTransform;

    private void Start()
    {
        Button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        float buttonWidth = ButtonRectTransform.rect.width;
        float buttonHeight = ButtonRectTransform.rect.height;
        float windowLeft = WindowRectTransform.rect.xMin;
        float windowRight = WindowRectTransform.rect.xMax;
        float windowTop = WindowRectTransform.rect.yMax;
        float windowBottom = WindowRectTransform.rect.yMin;
        
        float randomX = Random.Range(windowLeft + buttonWidth / 2, windowRight - buttonWidth / 2);
        float randomY = Random.Range(windowBottom + buttonHeight / 2, windowTop - buttonHeight / 2);
        
        ButtonRectTransform.anchoredPosition = new Vector2(randomX, randomY);
    }
}