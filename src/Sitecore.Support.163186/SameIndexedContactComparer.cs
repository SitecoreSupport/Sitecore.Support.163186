using Sitecore.ContentSearch.Analytics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Cintel
{
    class SameIndexedContactComparer : EqualityComparer<IndexedContact>
    {
        public override bool Equals(IndexedContact c1, IndexedContact c2)
        {
            string id1 = c1.UniqueId.Value.ToString();
            string id2 = c2.UniqueId.Value.ToString();
            return id1.Equals(id2, StringComparison.CurrentCultureIgnoreCase);
        }


        public override int GetHashCode(IndexedContact c)
        {
            return base.GetHashCode();
        }
    }
}