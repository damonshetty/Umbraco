using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace Project.PetaPoco
{
    public class PetaPocoRegisterEvents: ApplicationEventHandler
    {
        //This happens everytime the Umbraco Application starts
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //Get the Umbraco Database context
            var dbCtx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(dbCtx.Database, applicationContext.ProfilingLogger.Logger, dbCtx.SqlSyntax);

            //Check if the DB table does NOT exist
            if (!db.TableExist("PetaPocoHomePageWhatsNew"))
            {
                //Create DB table - and set overwrite to false
                db.CreateTable<PetaPocoHomePageWhatsNew>(false);
            }

            if (!db.TableExist("PetaPocoOutOfDateContent"))
            {
                //Create DB table - and set overwrite to false
                db.CreateTable<PetaPocoOutOfDateContent>(false);
            }

            if (!db.TableExist("PetaPocoUserProfiles"))
            {
                //Create DB table - and set overwrite to false
                db.CreateTable<PetaPocoUserProfile>(false);
            }

        }
        
    }
}