using System.Collections.Generic;

namespace ManagerTaskService.Models
{
    /// <summary>
    /// Model class for list
    /// </summary>
    public class ListViewModel<T>
    {
        /// <summary>
        /// Gets or sets the items 
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// Gets or sets the paging info
        /// </summary>
        public PagingInfo PagingInfo { get; set; }
    }

    /// <summary>
    /// Model class for an paging info
    /// </summary>
    public class PagingInfo
    {
        /// <summary>
        /// Gets or sets the current page
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the pages
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets the page span
        /// </summary>
        public int PageSpan { get; set; }
    }
}