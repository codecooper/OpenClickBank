﻿using System.Runtime.Serialization;

namespace Ocelli.OpenClickBank.Builder.Data;

public enum ContractStatus
{
    [EnumMember(Value = "PENDING_START")] PENDING_START,
    [EnumMember(Value = "PENDING_APPROVAL")] PENDING_APPROVAL,
    [EnumMember(Value = "ACTIVE")] ACTIVE,
    [EnumMember(Value = "TERMINATED")] TERMINATED,
    [EnumMember(Value = "TERMINATION_REQUESTED")] TERMINATION_REQUESTED,
    [EnumMember(Value = "EXPIRED")] EXPIRED
}