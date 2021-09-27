using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public void ActivateElement(GameObject o)
    {
        RectTransform rect = o.GetComponent<RectTransform>();
        
        Vector2 posOrig = rect.anchoredPosition;
        rect.anchoredPosition = Vector2.up * 1000f;
        rect.DOAnchorPosY(posOrig.y, 0.5f);
        o.SetActive(true);
    }
    public void DeActivateElement(GameObject o)
    {
        RectTransform rect = o.GetComponent<RectTransform>();
        
        Vector2 posOrig = rect.anchoredPosition;
        rect.DOAnchorPosY(1000f, 0.5f).OnComplete(() =>
        {
            o.SetActive(false);
            rect.anchoredPosition = posOrig;
        });
    }
}