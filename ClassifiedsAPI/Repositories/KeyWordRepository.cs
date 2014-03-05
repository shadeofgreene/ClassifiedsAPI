using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedsAPI.Models;

namespace ClassifiedsAPI.Repositories
{
	public class KeyWordRepository : Controller
	{
		#region Properties
		ClassifiedsEntities _dataContext;
		#endregion

		#region Constructors
		public KeyWordRepository()
		{
			_dataContext = new ClassifiedsEntities();
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets the keywords associated to an item
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public List<KeyWord> GetKeyWordsByItem(int itemId)
		{
			try
			{
				var keywords = (from kw in _dataContext.KeyWords
								from i in _dataContext.Items
								where i.itemId == itemId
								select kw).ToList();
				return keywords;
			}
			catch
			{
				return null;
			}
		}
		#endregion
		
	}
}
