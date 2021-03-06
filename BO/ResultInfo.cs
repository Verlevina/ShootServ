﻿using System;

namespace BO
{
    public class ResultInfo
    {
        /// <summary>
        /// Прошло ли действие
        /// </summary>
        public bool IsOk { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Исключение, возникшее в методе
        /// </summary>
        public Exception Exc { get; set; }

        public ResultInfo()
        {
            IsOk = true;
            Exc = null;
            ErrorMessage = "";
        }
    }
}
