using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedsAPI.Models;
using ClassifiedsAPI.Repositories;

namespace ClassifiedsAPI.Controllers
{
	public class KeyWordController : Controller
	{
		#region Properties
		KeyWordRepository _keyWordRepository;
		#endregion

		#region Constructors
		public KeyWordController()
		{
			_keyWordRepository = new KeyWordRepository();
		}
		#endregion

		#region Public Methods
		public List<KeyWord> GetKeyWordsByItem(int itemId)
		{
			return _keyWordRepository.GetKeyWordsByItem(itemId);
		}
		#endregion
		
	}
}
