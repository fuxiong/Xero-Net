﻿using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Request
{
    [CollectionDataContract(Namespace = "", Name = "BankTransfers")]
    public class BankTransfersRequest : XeroRequest<BankTransfer>
    {
    }
}