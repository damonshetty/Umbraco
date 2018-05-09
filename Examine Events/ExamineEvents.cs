using Examine;
using Examine.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.BusinessLogic;
using Umbraco.Core;

namespace Umbraco_Internet_Liverpool_CCG.Models
{
    public class ExamineEvents : ApplicationEventHandler
    {
        public ExamineEvents()
        {
            BaseIndexProvider indexer = ExamineManager.Instance.IndexProviderCollection["FrontEndWebsiteIndexer"];
            indexer.GatheringNodeData += indexer_GatheringNodeData;
        }

        private void indexer_GatheringNodeData(object sender, IndexingNodeDataEventArgs e)
        {
            e.Fields["createDate"] = DateTime.Parse(e.Fields["createDate"]).ToString("yyyyMMdd000000000");
        }
    }
}