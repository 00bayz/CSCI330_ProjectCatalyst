using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI330_ProjectCatalyst
{
    public class TodoModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Property that records the date-time a todo was added. Must use the ISO8601 string format as follows:
        /// YYYY-MM-DD HH:MM:SS.SSS
        /// For example, 2021-03-31 14:45:05.123
        /// </summary>
        public string DateTimeAdded { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Property that holds the state of whether a todo has been marked as complete.
        /// 0 = incomplete (default)
        /// 1 = completed
        /// </summary>
        public int IsComplete { get; set; }
    }
}
