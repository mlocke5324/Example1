using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Example1;
using Example1.Controllers;

namespace Example1.Tests
{
	[TestFixture ()]
	public class HomeControllerTest
	{
		[Test ()]
		public void Index ()
		{
			// Arrange
			HomeController controller = new HomeController ();

			// Act
			ViewResult result = controller.Index () as ViewResult;

			// Assert
			Assert.AreEqual ("Now we're cooking!", result.ViewData ["Message"]);
		}
	}
}
