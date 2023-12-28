using System.Collections;
using UnityEngine;
using TMPro;

public class TipsScript : MonoBehaviour
{
    public TextMeshProUGUI caseIsStartedText;
    public float fadeInDuration = 1f;
    public float fadeOutDuration = 1f;
    public float delayBeforeFadeOut = 5f;

    private void Start()
    {
    
        caseIsStartedText.color = new Color(caseIsStartedText.color.r, caseIsStartedText.color.g, caseIsStartedText.color.b, 0f);
        caseIsStartedText.gameObject.SetActive(false);
    }

    public void StartAnimation()
    {
        
        StopAllCoroutines();

    
        caseIsStartedText.gameObject.SetActive(true);


        StartCoroutine(FadeInAndOut());
    }

    private IEnumerator FadeInAndOut()
    {
    
        float timer = 0f;
        while (timer < fadeInDuration)
        {
            float alpha = Mathf.Lerp(0f, 1f, timer / fadeInDuration);
            caseIsStartedText.color = new Color(caseIsStartedText.color.r, caseIsStartedText.color.g, caseIsStartedText.color.b, alpha);
            timer += Time.deltaTime;
            yield return null;
        }

    
        caseIsStartedText.color = new Color(caseIsStartedText.color.r, caseIsStartedText.color.g, caseIsStartedText.color.b, 1f);

    
        yield return new WaitForSeconds(delayBeforeFadeOut);


        timer = 0f;
        while (timer < fadeOutDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeOutDuration);
            caseIsStartedText.color = new Color(caseIsStartedText.color.r, caseIsStartedText.color.g, caseIsStartedText.color.b, alpha);
            timer += Time.deltaTime;
            yield return null;
        }

        caseIsStartedText.color = new Color(caseIsStartedText.color.r, caseIsStartedText.color.g, caseIsStartedText.color.b, 0f);


        caseIsStartedText.gameObject.SetActive(false);
    }
}
