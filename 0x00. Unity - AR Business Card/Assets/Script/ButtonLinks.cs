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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		GitHub();
		Twitter();
		Instagram();
		LinkedIn();
    }

	public void GitHub()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Application.OpenURL(GitHubURL);
		}
	}

	public void Twitter()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Application.OpenURL(TwitterURL);
		}
	}

	public void Instagram()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Application.OpenURL(InstagramURL);
		}
	}

	public void LinkedIn()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Application.OpenURL(LinkedInURL);
		}
	}
}
