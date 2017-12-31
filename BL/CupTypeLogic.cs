﻿using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /// <summary>
    /// БЛ для типа соревнования
    /// </summary>
    public class CupTypeLogic
    {
        private readonly EFCupType _dalCupType;

        public CupTypeLogic()
        {
            _dalCupType = new EFCupType();
        }

        public CupTypeParams Get(int id)
        {
            return _dalCupType.Get(id);
        }

        public List<CupTypeParams> GetAll()
        {
            return _dalCupType.GetAll();
        }
    }
}
