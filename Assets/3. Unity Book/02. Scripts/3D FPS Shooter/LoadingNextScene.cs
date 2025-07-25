using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingNextScene : MonoBehaviour
{
   public int sceneNumber = 2;
   public Slider loadingSlider;
   public TextMeshProUGUI loadingText;

   IEnumerator TransitionNextScene(int num)
   {
      AsyncOperation ao = SceneManager.LoadSceneAsync(num);

      ao.allowSceneActivation = false; // 로드가 왼료가 되어도 로드 X
   }
}