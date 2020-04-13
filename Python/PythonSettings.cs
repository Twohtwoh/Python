using DecisionsFramework.Data.ORMapper;
using DecisionsFramework.ServiceLayer;
using DecisionsFramework.ServiceLayer.Actions;
using DecisionsFramework.ServiceLayer.Actions.Common;
using DecisionsFramework.ServiceLayer.Utilities;
using DecisionsFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DecisionsFramework.Data.DataTypes;

/// <summary>
/// This class is used to create a single settings object that can be used
/// by flows and steps.  It will show up in the portal in /System/Settings for 
/// Portal Administrators.
/// </summary>
namespace Python
{
    [ORMEntity]
    [DataContract]
    public class PythonSettings : AbstractModuleSettings
    {
        public PythonSettings()
        {
            EntityName = "Python Module Settings";
        }


        [ORMField]
        public string PythonDirectory { get; set; }
        [ORMField]
        public string PythonScriptDirectory { get; set; }
        //[ORMField]
        //public FileDataReference[] UploadFile { get; set; }


        //[ORMField]
        //public FileDataReference[] DownloadFile { get; set; }

        public override BaseActionType[] GetActions(AbstractUserContext userContext, EntityActionType[] types)
        {
            List<BaseActionType> results = new List<BaseActionType>(base.GetActions(userContext, types));

            results.Add(new EditObjectAction(typeof(PythonSettings), "Edit", null, "Edit", ()=> { return this; }, SaveChanges));

            return results.ToArray();
        }

        private void SaveChanges(AbstractUserContext userContext, object obj)
        {
            new DynamicORM().Store((IORMEntity)obj);
        }
    }
}
