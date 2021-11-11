using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinks : MonoBehaviour
{
	// Public Strings to save URLs
	public string GitHubURL;
	public string TwitterURL;
	public string InstagramURL;
	public string LinkedInURL;

	public void GitHub()
	{
		Application.OpenURL(GitHubURL);
	}

	public void Twitter()
	{
		Application.OpenURL(TwitterURL);
	}

	public void Instagram()
	{
		Application.OpenURL(InstagramURL);
	}

	public void LinkedIn()
	{
		Application.OpenURL(LinkedInURL);
	}
}
