using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class User
{
	public User()
	{
		[HttpGet]
		[Route("/user/add")]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		[Route("/user/add")]
		public IActionResult SubmitAddUserForm(User newUser, string verify)
		{
            UserData.Add(newUser, verify);


            return Redirect("/user");
        }
	}
}
