	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

	public void LoadNextScene()

	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		SceneManager.LoadScene(currentSceneIndex + 1);

	}
	public void LoadStartScene()
	{
		SceneManager.LoadScene(0);
		

	}
	public void LoadPreviousScene()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		SceneManager.LoadScene(currentSceneIndex - 1);
	}

	public void LoadExploreScene()
	{
		SceneManager.LoadScene(2);
	}
	public void LoadManageScene()
	{
		SceneManager.LoadScene(3);
	}
	public void LoadProfileScene()
	{
		SceneManager.LoadScene(4);
	}
	public void LoadEmailScene()
    {
		SceneManager.LoadScene(1);
    }
}
