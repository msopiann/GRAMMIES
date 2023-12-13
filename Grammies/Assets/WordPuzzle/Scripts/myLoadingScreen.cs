using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class myLoadingScreen : MonoBehaviour
{

	void Update()
	{

		if (Application.GetStreamProgressForLevel(2) == 1 && Time.timeSinceLevelLoad > 6.0f)
		{
			SceneManager.LoadScene(5);
		}

	}
}
