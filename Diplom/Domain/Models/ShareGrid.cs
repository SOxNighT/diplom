using Microsoft.EntityFrameworkCore;
using MvcContrib.UI.Grid;
using System.Collections.Generic;
using Tinkoff.InvestApi.V1;

namespace JWT.Domain.Models
{
    public class ShareGrid : IGridModel<Share>
    {
        public IGridRenderer<Share> Renderer { get; set; }

        public IList<GridColumn<Share>> Columns { get; set; }

        public IGridSections<Share> Sections { get; set; }

        public string EmptyText { get; set; }
        public IDictionary<string, object> Attributes { get; set; }
        public GridSortOptions SortOptions { get; set; }
        public string SortPrefix { get; set; }
    }
}
