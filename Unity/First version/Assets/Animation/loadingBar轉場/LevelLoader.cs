using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    private void Start()
    {
        StartCoroutine(waitfor());
    }

    IEnumerator waitfor()
    {
        yield return new WaitForSeconds(22);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadAsynchronously("БаЋЧ"));
    }
    IEnumerator LoadAsynchronously (string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
        
    }
}
