using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI330_ProjectCatalyst
{
    class EventModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Property that records the date-time an event was added. Must use the ISO8601 string format as follows:
        /// YYYY-MM-DD HH:MM:SS.SSS
        /// For example, 2021-03-31 14:45:05.123
        /// </summary>
        public string DateTimeAdded { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Property that records the date an event happens. Must use the ISO8601 string format as follows:
        /// YYYY-MM-DD
        /// For example, 2021-03-31
        /// </summary>
        public int EventDate { get; set; }
    }
}
