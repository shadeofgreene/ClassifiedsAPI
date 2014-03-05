using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedsAPI.Models;

namespace ClassifiedsAPI.Controllers
{
	public class SearchController : Controller
	{
		public List<Item> searchClassifiedsItems(string searchString, int numberOfItems)
		{
			/** 
			 * TODO: search algorithm that returns a list of classifieds items based on the following heirarchy of importance
			 * - By Keywords (pulled in from itemName and itemDescription) when item is saved
			 * - By Tag Names (chosen by user, user can create his/her own tag at X amount of reputation points)
			 * - By Category (chosen by user)
			 ***/
			return null;
		}
	}
}
