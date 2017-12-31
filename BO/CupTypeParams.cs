﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Тип соревнования
    /// </summary>
    public class CupTypeParams
    {
        /// <summary>
        /// ид.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// кейчар
        /// </summary>
        public string Keychar { get; set; }
    }
}
