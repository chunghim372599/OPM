﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface IContract
    {
        //public List<ContractMdl> GetAllContract();
        public int InsertNewContract(ContractObj contract);
        public IContract GetDetailContract(string strIdContract);
        public List<IContract> GetAllContract();

    }
}