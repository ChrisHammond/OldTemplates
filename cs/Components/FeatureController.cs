/*
' Copyright (c) 2010 $YourCompany$
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace $NameSpace$$safeprojectname$.Components
{

	/// -----------------------------------------------------------------------------
	/// <summary>
	/// The Controller class for $safeprojectname$
	/// </summary>
	/// -----------------------------------------------------------------------------
	public class FeatureController : IPortable, ISearchable, IUpgradeable
	{

	#region Public Methods

	

	#endregion
	
	#region Optional Interfaces

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// ExportModule implements the IPortable ExportModule Interface
		/// </summary>
		/// <param name="ModuleID">The Id of the module to be exported</param>
		/// -----------------------------------------------------------------------------
		public string ExportModule(int ModuleID)
		{
			//string strXML = "";

			//List<$safeprojectname$Info> col$safeprojectname$s = Get$safeprojectname$s(ModuleID);
			//if (col$safeprojectname$s.Count != 0)
			//{
			//    strXML += "<$safeprojectname$s>";

			//    foreach ($safeprojectname$Info obj$safeprojectname$ in col$safeprojectname$s)
			//    {
			//        strXML += "<$safeprojectname$>";
			//        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(obj$safeprojectname$.Content) + "</content>";
			//        strXML += "</$safeprojectname$>";
			//    }
			//    strXML += "</$safeprojectname$s>";
			//}

			//return strXML;

			throw new System.NotImplementedException("The method or operation is not implemented.");
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// ImportModule implements the IPortable ImportModule Interface
		/// </summary>
		/// <param name="ModuleID">The Id of the module to be imported</param>
		/// <param name="Content">The content to be imported</param>
		/// <param name="Version">The version of the module to be imported</param>
		/// <param name="UserId">The Id of the user performing the import</param>
		/// -----------------------------------------------------------------------------
		public void ImportModule(int ModuleID, string Content, string Version, int UserID)
		{
			//XmlNode xml$safeprojectname$s = DotNetNuke.Common.Globals.GetContent(Content, "$safeprojectname$s");
			//foreach (XmlNode xml$safeprojectname$ in xml$safeprojectname$s.SelectNodes("$safeprojectname$"))
			//{
			//    $safeprojectname$Info obj$safeprojectname$ = new $safeprojectname$Info();
			//    obj$safeprojectname$.ModuleId = ModuleID;
			//    obj$safeprojectname$.Content = xml$safeprojectname$.SelectSingleNode("content").InnerText;
			//    obj$safeprojectname$.CreatedByUser = UserID;
			//    Add$safeprojectname$(obj$safeprojectname$);
			//}

			throw new System.NotImplementedException("The method or operation is not implemented.");
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// GetSearchItems implements the ISearchable Interface
		/// </summary>
		/// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
		/// -----------------------------------------------------------------------------
		public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
		{
			//SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

			//List<$safeprojectname$Info> col$safeprojectname$s = Get$safeprojectname$s(ModInfo.ModuleID);

			//foreach ($safeprojectname$Info obj$safeprojectname$ in col$safeprojectname$s)
			//{
			//    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, obj$safeprojectname$.Content, obj$safeprojectname$.CreatedByUser, obj$safeprojectname$.CreatedDate, ModInfo.ModuleID, obj$safeprojectname$.ItemId.ToString(), obj$safeprojectname$.Content, "ItemId=" + obj$safeprojectname$.ItemId.ToString());
			//    SearchItemCollection.Add(SearchItem);
			//}

			//return SearchItemCollection;

			throw new System.NotImplementedException("The method or operation is not implemented.");
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// UpgradeModule implements the IUpgradeable Interface
		/// </summary>
		/// <param name="Version">The current version of the module</param>
		/// -----------------------------------------------------------------------------
		public string UpgradeModule(string Version)
		{
			throw new System.NotImplementedException("The method or operation is not implemented.");
		}

	#endregion

	}

}
